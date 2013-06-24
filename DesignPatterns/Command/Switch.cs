using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class Switch
    {
        private List<ICommand> _commands = new List<ICommand>();

        public ICommand ICommand
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.execute();
        }
    }
}
