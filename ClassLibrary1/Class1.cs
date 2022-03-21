using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class KU
    {
        /// <summary>
        /// Вычисление квадратного уравнения
        /// </summary>
        /// <param name="a">коэффициент</param>
        /// <param name="b">коэффициент</param>
        /// <param name="c">коэффициент</param>
        /// <param name="d">дискриминант</param>
        /// <param name="x1">1 корень</param>
        /// <param name="x2">2 корень</param>
        /// <param name="message">сообщение</param>
        public static void KvUr(
            double a, double b, double c,
            out double d, out double x1, out double x2,
            out string message)
        {
            d = x1 = x2 = double.NaN;

            if (a == 0)
            {
                LnUr(b, c, out x1, out message);
            }
            else
            {
                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    message = "Дискриминант больше нуля, 2 корня.";
                }
                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    message = "Дискриминант равен нулю, 1 корня.";
                }
                else
                {
                    message = "Дискриминант меньше нуля, нет корней.";
                }
            }

        }

        public static void LnUr(double k, double b,
            out double x, out string message)
        {
            if (k == 0)
            {
                x = double.NaN;
                if (b == 0) message = "Прямая совпадает с осью x, ответ R";
                else message = "Нет решений";
            }
            else
            {
                x = -b / k;
                message = null;
            }
        }
    }
}
