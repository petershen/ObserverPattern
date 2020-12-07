using ObserverPattern.AbstractParties;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ConcreteParties
{
    public class FinancialAdvisor : Issuer
    {
        private string _advice;

        public string Advice
        {
            get { return _advice; }
            set { _advice = value; }
        }
    }
}
