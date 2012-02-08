﻿using Machine.Specifications;

namespace PlainElastic.Net.Tests.Integration
{
    [Subject(typeof(SearchCommandBuilder))]
    class When_multiple_indexes_and_types_SearchCommand_built
    {

        Because of = () => result = new SearchCommandBuilder(indexes: new[] { "index1", "index2" }, types: new[] { "Type1", "Type2" })
            .Pretty()
            .BuildCommand();

        It should_starts_with_indexes_and_types = () => result.ShouldStartWith("index1,index2/type1,type2");

        It should_return_correct_value = () => result.ShouldEqual(@"index1,index2/type1,type2/_search?pretty=true");


        private static string result;
    }
}
