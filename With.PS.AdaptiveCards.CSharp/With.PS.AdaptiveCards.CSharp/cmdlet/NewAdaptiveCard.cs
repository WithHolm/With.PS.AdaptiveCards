using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdaptiveCards;
using System.Management.Automation;

namespace With.AdaptiveCards.CSharp
{
    [Cmdlet(VerbsCommon.New, "AdaptiveCard")]
    public class NewAdaptivecard:Cmdlet
    {

        [Parameter]
        public string Speak { get; set; }

        [Parameter]
        public List<AdaptiveAction> Action { get; set; }

        [Parameter]
        public List<AdaptiveElement> Body { get; set; }

        private AdaptiveCard _card { get; set; }

        protected override void BeginProcessing()
        {
            _card = new AdaptiveCard();
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
        }

        protected override void EndProcessing()
        {
            _card.ToJson();
            base.EndProcessing();
        }
    }
}
