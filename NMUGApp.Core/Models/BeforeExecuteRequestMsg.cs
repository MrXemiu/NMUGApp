using MvvmCross.Plugins.Messenger;

namespace NMUGApp.Core.Models
{
    public class BeforeExecuteRequestMsg : MvxMessage
    {
        #region Public Constructors

        public BeforeExecuteRequestMsg(object sender) : base(sender)
        {
        }

        #endregion Public Constructors
    }
}