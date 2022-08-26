using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SMDR.Infratructure
{
    using Auxilary;
    using Base;
    using Models;
    public abstract class SMDRParserBase<TCallLog> : IParser<IEnumerable<TCallLog>>
        where TCallLog : class, ICallLog
    {
        public SMDRParserBase(IParserSettings settings)
        {
            this.Settings = settings;
        }
        public IParserSettings Settings { get; set; }
        /// <summary>
        /// Parses an smdr context as a list of call log
        /// </summary>
        /// <param name="context">smdr record context</param>
        /// <returns></returns>
        public virtual IEnumerable<TCallLog> Parse(string context)
        {
            var lines = context?.Split(Settings.LineFeed, Settings.CarriageReturn);
            if (lines == null)
            {
                yield break;
            }
            foreach (var line in lines)
            {
                if (line.ShouldParseLine())
                {
                    yield return ParseLine(line);
                }
            }
        }
        /// <summary>
        /// Parses a single line call record of an smdr context
        /// </summary>
        /// <param name="context">Context to be parsed</param>
        /// <returns></returns>
        /// Exceptions:
        ///   T:System.ArgumentOutOfRangeException:
        ///     startIndex plus length indicates a position not within this instance. -or- startIndex 
        ///     or length is less than zero in a column due to setting.
        public virtual TCallLog ParseLine(string line)
        {
            var type = typeof(TCallLog);
            var instance = Activator.CreateInstance(type) as TCallLog;
            CultureInfo format = new CultureInfo("en-us");
            foreach (var item in type.GetProperties())
            {
                var column = this.Settings.Columns.FirstOrDefault(c => c.Name.ToLower(format) == item.Name.ToLower(format));
                try
                {
                    if (column == null)
                        continue;
                    var value = line.Substring(column.StartIndex, column.Length);

                    if (Settings.TrimWhiteSpaces)
                        value = value.TrimStart().TrimEnd();
                    instance.GetType().GetProperty(item.Name).SetValue(instance, value);
                }
                catch (Exception e)
                {
                    throw;
                }

            }
            instance.Raw = line;
            instance.Enhance();
            return instance;
        }


    }

}
