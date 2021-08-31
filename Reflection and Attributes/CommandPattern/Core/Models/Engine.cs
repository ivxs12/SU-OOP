using System;
using CommandPattern.Core.Contracts;
using CommandPattern.Core.Models.Commands;

namespace CommandPattern.Core.Models
{
    class Engine : IEngine
    {
        private readonly ICommandInterpreter command;
        public Engine(ICommandInterpreter command)
        {
            this.command = command;
        }
        public void Run()
        {
            try
            {
                while (true)
                {
                    string args = Console.ReadLine();
                    string output = command.Read(args);
                    if (!(output == "123"))
                    {
                        Console.WriteLine(output);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
