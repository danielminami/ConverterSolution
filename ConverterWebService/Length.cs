using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConverterWebService {
    public class Length {

        private string Operator;
        private double Factor;

        public double calculateLength(double value, string from, string to) {
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
                case "F":
                    if (to == "M") {
                        Operator = "/";
                        Factor = 3.281;
                    } else if (to == "K") {
                        Operator = "/";
                        Factor = 3281;
                    }
                break;
                case "M":
                    if (to == "F") {
                        Operator = "*";
                        Factor = 3.281;
                    } else if (to == "K") {
                        Operator = "*";
                        Factor = 1000;
                    }
                break;
                case "K":
                    if (to == "F") {
                        Operator = "*";
                        Factor = 3281;
                    } else if (to == "M") {
                        Operator = "/";
                        Factor = 1000;
                    }
                break;
            }

        }
    }

    

}