namespace FFmpegArgs.Filters.Expressions
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-utils.html#Expression-Evaluation <br></br>
    /// https://en.wikipedia.org/wiki/Shunting-yard_algorithm <br></br>
    /// https://stackoverflow.com/questions/tagged/shunting-yard <br></br>
    /// 
    /// </summary>
    public class FFmpegExpression
    {
        /// <summary>
        /// 
        /// </summary>
        public static FFmpegExpression DefaultInstance { get; } = new FFmpegExpression();

        static readonly IEnumerable<string> _binaryOperators = new List<string>()
        {
          "+", "-", "*", "/", "^"
        };
        static readonly IEnumerable<string> _unaryOperators = new List<string>()
        {
          "+", "-"
        };
        static readonly IEnumerable<string> _prefixes = new List<string>()
        {
        };
        static readonly IEnumerable<string> _functionName = new List<string>()
        {
          "abs",
          "acos",
          "asin",
          "atan",
          "atan2",
          "between",
          "bitand",
          "bitor",
          "ceil",
          "clip",
          "cos",
          "cosh",
          "eq",
          "exp",
          "floor",
          "gauss",
          "gcd",
          "gt",
          "gte",
          "hypot",
          "if",
          "ifnot",
          "isinf",
          "isnan",
          "ld",
          "lerp",
          "log",
          "lt",
          "lte",
          "max",
          "min",
          "mod",
          "not",
          "pow",
          "print",
          "random",
          "root",
          "round",
          "sgn",
          "sin",
          "sinh",
          "sqrt",
          "squish",
          "st",
          "tan",
          "tanh",
          "taylor",
          "time",
          "trunc",
          "while",
        };
        static readonly IEnumerable<string> _functionSY = new List<string>()
        {
          "abs_1",
          "acos_1",
          "asin_1",
          "atan_1",
          "atan2_2",
          "between_3",
          "bitand_2",
          "bitor_2",
          "ceil_1",
          "clip_3",
          "cos_1",
          "cosh_1",
          "eq_2",
          "exp_1",
          "floor_1",
          "gauss_1",
          "gcd_2",
          "gt_2",
          "gte_2",
          "hypot_2",
          "if_2",
          "if_3",
          "ifnot_2",
          "ifnot_3",
          "isinf_1",
          "isnan_1",
          "ld_1",
          "lerp_3",
          "log_1",
          "lt_2",
          "lte_2",
          "max_2",
          "min_2",
          "mod_2",
          "not_1",
          "pow_2",
          "print_1",
          "print_2",
          "random_1",
          "root_2",
          "round_1",
          "sgn_1",
          "sin_1",
          "sinh_1",
          "sqrt_1",
          "squish_1",
          "st_2",
          "tan_1",
          "tanh_1",
          "taylor_2",
          "taylor_3",
          "time_1",
          "trunc_1",
          "while_2",
        };
        static readonly IEnumerable<string> _consts = new List<string>()
        {
          "PI",
          "E",
          "PHI",
          "INT_MAX",
          "NAN"
        };
        readonly IEnumerable<string> _adv_variables;
        readonly IEnumerable<string> _adv_functionName;
        readonly IEnumerable<string> _adv_functionSY;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="variables"></param>
        /// <param name="advFunctions"></param>
        public FFmpegExpression(IEnumerable<string> variables = null, IEnumerable<ShuntingYardFunction> advFunctions = null)
        {
            this._adv_variables = variables ?? new List<string>();
            this._adv_functionName = advFunctions?.Select(x => x.Name).Concat(_functionName) ?? _functionName;
            this._adv_functionSY = advFunctions?.Select(x => x.SY).Concat(_functionSY) ?? _functionSY;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expressions"></param>
        /// <returns></returns>
        public IEnumerable<string> Checks(params ExpressionValue[] expressions)
        {
            if (expressions is null) throw new ArgumentNullException(nameof(expressions));
            return Checks(expressions.AsEnumerable());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expressions"></param>
        /// <returns></returns>
        public IEnumerable<string> Checks(IEnumerable<ExpressionValue> expressions)
        {
            if (expressions is null) throw new ArgumentNullException(nameof(expressions));
            bool isEmpty = true;
            foreach (var item in expressions)
            {
                isEmpty = false;
                yield return Check(item);
            }
            if (isEmpty) throw new InvalidInputExpressionException($"input is empty");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <exception cref="InvalidTokenExpressionException"></exception>
        /// <exception cref="InvalidInputExpressionException"></exception>
        /// <returns></returns>
        public string Check(ExpressionValue expression)
        {
            return Check(expression?.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="shuntingYard"></param>
        /// <exception cref="InvalidTokenExpressionException"></exception>
        /// <exception cref="InvalidInputExpressionException"></exception>
        /// <returns></returns>
        public string Check(ExpressionValue expression, out string shuntingYard)
        {
            return Check(expression?.ToString(), out shuntingYard);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <exception cref="InvalidTokenExpressionException"></exception>
        /// <exception cref="InvalidInputExpressionException"></exception>
        /// <returns></returns>
        public string Check(string expression)
        {
            return Check(expression, out string tmp);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="shuntingYard"></param>
        /// <exception cref="InvalidTokenExpressionException"></exception>
        /// <exception cref="InvalidInputExpressionException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public string Check(string expression, out string shuntingYard)
        {
            if (string.IsNullOrWhiteSpace(expression)) throw new ArgumentNullException(nameof(expression));

            //https://en.wikipedia.org/wiki/Shunting-yard_algorithm
            //check....
            string[] tokens = Regex.Split(expression, @"([0-9]+\.[0-9]+|[0-9]+|[*+\-\/(),]|[A-z]+)").Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            Stack<string> stacks = new Stack<string>();
            Queue<string> outputs = new Queue<string>();
            for (int i = 0; i < tokens.Length; i++)
            {
                if (_adv_functionName.Any(x => x.Equals(tokens[i])))
                {
                    stacks.Push(tokens[i]);// if is function -> push to stack
                }
                else if ("(".Equals(tokens[i]))
                {
                    stacks.Push(tokens[i]);      //if is ( -> push to stack
                }
                else if (_binaryOperators.Any(x => x.Equals(tokens[i])))
                {
                    //Pop stack to output
                    //Push token to stack
                    if (stacks.Count > 0 && !stacks.First().Equals("(") && !stacks.First().Equals(",")) outputs.Enqueue(stacks.Pop());
                    stacks.Push(tokens[i]);
                }
                else if (                                         //if is number, const, variables
                  double.TryParse(tokens[i], out double n) ||     //number
                  _adv_variables.Any(x => x.Equals(tokens[i])) ||     //variables
                  _consts.Any(x => x.Equals(tokens[i])))          //const
                {
                    outputs.Enqueue(tokens[i]);//-> push to queue
                }
                else if (",".Equals(tokens[i]))//comma, that mean is inside function
                {
                    while (!",".Equals(stacks.First()) && !"(".Equals(stacks.First()))//not , and (
                    {
                        outputs.Enqueue(stacks.Pop());
                        if (stacks.Count == 0) throw new InvalidInputExpressionException($"Invalid comma (,) not inside function");//that mean not inside function, wrong input
                    }
                    stacks.Push(tokens[i]);
                }
                else if (")".Equals(tokens[i]))//pop stack to output & pop stack
                {
                    //pop stack to output
                    //Repeated until "(" is at the top of the stack
                    int comma_count = 0;
                    while (true)
                    {
                        if (stacks.Count == 0)
                            throw new InvalidInputExpressionException($"Surplus )");
                        string pop = stacks.Pop();
                        if (pop.Equals("("))
                        {
                            if (stacks.Count > 0 && _adv_functionName.Any(x => x.Equals(stacks.First())))
                            {
                                outputs.Enqueue($"{stacks.Pop()}_{comma_count + 1}");
                            }
                            break;
                        }
                        else if (pop.Equals(","))
                        {
                            comma_count++;
                        }
                        else outputs.Enqueue(pop);
                    }
                }
            }
            while (stacks.Count > 0) outputs.Enqueue(stacks.Pop());//end Pop entire stack to output
            //check invalid
            var invalid_tokens = outputs
              .Except(_adv_functionSY)
              .Except(_consts)
              .Except(_binaryOperators)
              .Except(_adv_variables)
              .Where(x => !double.TryParse(x, out double y))
              .ToList();
            if (invalid_tokens.Count > 0) throw new InvalidTokenExpressionException(string.Join(" ", invalid_tokens));
            shuntingYard = string.Join(" ", outputs);
            return expression;
        }

#if DEBUG
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public override string ToString()
        {
            throw new InvalidOperationException();
        }
#endif
    }
}
