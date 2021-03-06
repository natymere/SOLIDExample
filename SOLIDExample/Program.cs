using System;
using System.Text;

namespace SOLIDExample
{
    public class DiagnosticProvider
    {
        public object[,] RetrieveDiagnosticData(Car target)
        {
            object[,] diagnosticData = new object[4, 2]
            {
                {"Mileage", 4232.15},
                {"Fuel Level", 0.65},
                {"Oil Life", 0.44},
                {"ape", "gang"}
            };

            return diagnosticData;
        }
    }

    public class Car
    {
    }

    public class DiagnosticDisplayProvider
    {
        public string PrintDiagnosticInfo(object[,] diagnosticData)
        {
            StringBuilder diagnosticString = new StringBuilder();

            for (int i = 0; i < diagnosticData.GetLength(0); i++)
            {
                diagnosticString.Append(
                    "[" + diagnosticData[i, 0].ToString() + "]\t" + diagnosticData[i, 1] + "\n"
                );
            }

            return diagnosticString.ToString();
        }
    }
    
    public class DiagnosticDisplayLogProvider
    {
        public string PrintDiagnosticInfo(object[,] diagnosticData)
        {
            StringBuilder diagnosticString = new StringBuilder();

            for (int i = 0; i < diagnosticData.GetLength(0); i++)
            {
                diagnosticString.Append(
                    diagnosticData[i, 0].ToString() + "\t-\t" + diagnosticData[i, 1] + "\t|\t"
                );
            }

            return diagnosticString.ToString();
        }
    }

    public static class Program
    {
        public static void Main()
        {
            Car myCar = new Car();
            DiagnosticProvider provider = new DiagnosticProvider();
            var data = provider.RetrieveDiagnosticData(myCar);

            DiagnosticDisplayProvider display = new DiagnosticDisplayProvider();
            var displayString = display.PrintDiagnosticInfo(data);
            
            Console.WriteLine(displayString);
        }
    }


} 