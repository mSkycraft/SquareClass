namespace Square
{
    public class Square
    {
        public double S;
        public Dictionary<string, double> othersResult = new Dictionary<string, double>();
        public Square(string type, double[] args) {
            switch (type.ToLower())
            {
                case "circle":
                    if (args.Length == 1)
                        S = args[0] * args[0] * Math.PI;
                    break;
                case "triangle":
                    if (args.Length == 3)
                    {
                        double p = (args[0] + args[1] + args[2]) / 2;
                        S = Math.Sqrt(p * (p - args[0]) * (p - args[1]) * (p - args[2]));
                        if (args[0] < args[1])
                        {
                            if (args[2] < args[1])
                            {
                                if (args[1] * args[1] == args[0] * args[0] + args[2] * args[2])
                                {
                                    othersResult.Add("rectangular", 1);
                                }
                                else
                                {
                                    othersResult.Add("rectangular", 0);
                                }

                            }
                            else
                            {
                                if (args[2] * args[2] == args[0] * args[0] + args[1] * args[1])
                                {
                                    othersResult.Add("rectangular", 1);
                                }
                                else
                                {
                                    othersResult.Add("rectangular", 0);
                                }
                            }
                        }
                        else
                        {
                            if (args[2] < args[0])
                            {
                                if (args[0] * args[0] == args[1] * args[1] + args[2] * args[2])
                                {
                                    othersResult.Add("rectangular", 1);
                                }
                                else
                                {
                                    othersResult.Add("rectangular", 0);
                                }
                            }
                            else
                            {
                                if (args[2] * args[2] == args[0] * args[0] + args[2] * args[2])
                                {
                                    othersResult.Add("rectangular", 1);
                                }
                                else
                                {
                                    othersResult.Add("rectangular", 0);
                                }
                            }
                        }
                    }
                    break;
                default:
                    S = 0;
                    break;
            }
             
        }
    }
}