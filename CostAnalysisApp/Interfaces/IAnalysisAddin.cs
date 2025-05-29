using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostAnalysis.WinForms.Interfaces
{
    internal interface IAnalysisAddin
    {
        string Name { get; }
        void Execute(System.Windows.Forms.Form parent);
    }
}
