using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConverterWebService {
    public class Weight {

        private string Operator;
        private double Factor;

        public double calculateWeight(double value, string from, string to) {
            getConverterFactor(from, to);

            if (Operator == "*") {
                return value * Factor;
            } else if (Operator == "/") {
                return value / Factor;
            }

            //In case of an invalid input
            return 0;
        }

        private void getConverterFactor(string from, string to) {
            switch (from) {
                case "P":
                    if (to == "G") {
                        Operator = "*";
                        Factor = 454;
                    } else if (to == "K") {
                        Operator = "/";
                        Factor = 2.205;
                    }
                    break;
                case "G":
                    if (to == "P") {
                        Operator = "/";
                        Factor = 454;
                    } else if (to == "K") {
                        Operator = "/";
                        Factor = 1000;

                    }
                    break;
                case "K":
                    if (to == "P") {
                        Operator = "*";
                        Factor = 2.205;
                    } else if (to == "G") {
                        Operator = "*";
                        Factor = 1000;

                    }
                    break;
            }

        }
    }
}