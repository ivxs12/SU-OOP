using System;
using CommandPattern.Core.Contracts;
using System.Reflection;
using System.Linq;

namespace CommandPattern.Core.Models
{
    class CommandInterpreter : ICommandInterpreter
    {
        private ICommand command;
        public string Read(string args)
        {
            string[] input = args.Split();
            if (string.IsNullOrEmpty(input[0]))
            {
                throw new ArgumentException("Invalid command type");
            }
            Type type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == $"{input[0]}Command");
            input = input[1..];
            this.command = (ICommand) Activator.CreateInstance(type);
            return this.command.Execute(input);

        }
    }
}
