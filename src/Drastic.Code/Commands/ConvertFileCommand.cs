// <copyright file="ConvertFileCommand.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using CommandLine;

namespace Drastic.Code.Commands
{
    [Verb("convert", HelpText = "Convert File from one language to another.")]
    public class ConvertFileCommand
    {
        /// <summary>
        /// Gets or sets the language to convert to.
        /// </summary>
        [Option(HelpText = "Language to convert to", Required = true)]
        public string? To { get; set; }

        /// <summary>
        /// Gets or sets the language to convert to.
        /// </summary>
        [Option(HelpText = "Language to convert from", Required = true)]
        public string? From { get; set; }

        /// <summary>
        /// Executes Scan Users Command.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task ExecuteAsync()
        {

        }

        /// <summary>
        /// Called when disposing.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Called when disposing.
        /// </summary>
        /// <param name="disposing">Is Disposing.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }
    }
}
