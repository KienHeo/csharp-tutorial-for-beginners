using System;

namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            const ShippingMethod method = ShippingMethod.Express;
            Console.WriteLine((int) method);
            const int methodId = 3;
            Console.WriteLine((ShippingMethod) methodId);

            Console.WriteLine(method.ToString());

            const string methodName = "Express";

//            var a = Enum.Parse<ShippingMethod>(methodName);
            var shippingMethod = (ShippingMethod) Enum.Parse(enumType: typeof(ShippingMethod), value: methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}