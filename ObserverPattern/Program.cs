using ObserverPattern.ConcreteParties;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FinancialAdvisor advisor = new FinancialAdvisor();

            advisor.Attach(new Investor(advisor, "First Investor"));
            advisor.Attach(new Investor(advisor, "Second Investor"));
            advisor.Attach(new Investor(advisor, "Third Investor"));

            advisor.Advice = "KEEP";
            advisor.Notify();

            Console.ReadKey();
        }
    }
}
