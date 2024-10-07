namespace Padel.Api
{
    public static class ApiEndpoints
    {
        private const string ApiBase = "api";

        public static class Matches
        {
            private const string Base = $"{ApiBase}/matches";

            public const string Create = Base;

            public const string GetAll = Base;

            public const string Get = Base + "/{id}";

            public const string Update = Base + "/{id}";

            public const string Delete = Base + "/{id}";

        }

    }
}
