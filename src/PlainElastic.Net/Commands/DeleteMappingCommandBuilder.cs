﻿namespace PlainElastic.Net
{
    /// <summary>
    /// Builds a command that allows to delete a mapping (type) along with its data.
    /// Note, most times, it make more sense to reindex the data into a fresh index compared to delete large chunks of it.
    /// http://www.elasticsearch.org/guide/reference/api/admin-indices-delete-mapping.html
    /// </summary>
    public class DeleteMappingCommandBuilder: CommandBuilder<DeleteMappingCommandBuilder>
    {
        public string Index { get; private set; }

        public string Type { get; private set; }


        public DeleteMappingCommandBuilder(string index, string type = null)
        {
            Index = index;
            Type = type;
        }

        protected override string BuildUrlPath()
        {
            return UrlBuilder.BuildUrlPath(Index, Type);
        }
    }
}
