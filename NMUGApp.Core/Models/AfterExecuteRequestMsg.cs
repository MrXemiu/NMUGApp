using MvvmCross.Plugins.Messenger;

namespace NMUGApp.Core.Models
{
    public class AfterExecuteRequestMsg : MvxMessage
    {
        #region Public Constructors

        public AfterExecuteRequestMsg(object sender) : base(sender)
        {
        }

        #endregion Public Constructors
    }
}