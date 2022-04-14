using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeSubmissionConole
{
    public class DuplicatePlayException : Exception
    {
        public DuplicatePlayException(string message) : base(message)
        {

        }
    }
}
