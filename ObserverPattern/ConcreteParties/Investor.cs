using ObserverPattern.AbstractParties;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ConcreteParties
{
    public class Investor : Observer
    {
        private FinancialAdvisor _advisor;
        private readonly string _name;
        private string _investAdvice;

        public Investor(FinancialAdvisor advisor, string name)
        {
            _advisor = advisor;
            _name = name;
        }

        public override void Update()
        {
            _investAdvice = _advisor.Advice;
            Console.WriteLine("{0}'s new investment advice is {1}",
              _name, _investAdvice);
        }

        public FinancialAdvisor Advisor
        {
            get { return _advisor; }
            set { _advisor = value; }
        }
    }
}
