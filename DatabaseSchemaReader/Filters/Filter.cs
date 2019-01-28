using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DatabaseSchemaReader.Filters
{
    /// <summary>
    /// Exclude items when reading the schema
    /// </summary>
    public class Filter : IFilter
    {
        private readonly IList<string> _filterExclusions = new List<string>();

        /// <summary>
        /// An exclusions list. The implementation may use simple names, regex strings, or not use this list at all.
        /// </summary>
        /// <value>
        /// The exclusions.
        /// </value>
        public IList<string> FilterExclusions
        {
            get { return _filterExclusions; }
        }

        /// <summary>
        /// Excludes the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public virtual bool Exclude(string name)
        {
            return _filterExclusions.Any(filter => Regex.IsMatch(name, filter, RegexOptions.IgnoreCase));
        }
    }
}
