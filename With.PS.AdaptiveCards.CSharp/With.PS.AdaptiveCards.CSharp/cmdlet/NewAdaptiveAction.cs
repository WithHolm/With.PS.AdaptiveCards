using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdaptiveCards;
using System.Management.Automation;

namespace With.AdaptiveCards.CSharp
{
    [Cmdlet(VerbsCommon.New, "AdaptiveAction")]
    public class NewAdaptiveAction : Cmdlet
    {
        [Parameter]
        public string Speak { get; set; }

        private AdaptiveAction _Action { get; set; }

        protected override void BeginProcessing()
        {
            //adaptive
            //_Action = new AdaptiveAction();
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            
            // AdaptiveAction _Action = new AdaptiveAction();
            base.ProcessRecord();
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }
    }
}
