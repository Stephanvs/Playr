﻿using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace Playr.Api
{
    public static class WebApiConfig
    {
        public static HttpConfiguration GetConfiguration()
        {
            var config = new HttpConfiguration();

#if DEBUG
            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
#endif

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            Library.RegisterRoutes(config.Routes);
            Auth.RegisterRoutes(config.Routes);

            return config;
        }

        public static class Auth
        {
            public const string Login = "Auth-Login";
            public const string Logout = "Auth-Logout";
            public const string Registration = "Auth-Registration";

            public static void RegisterRoutes(HttpRouteCollection routes)
            {
                routes.MapHttpRoute(
                    name: Login,
                    routeTemplate: "api/auth/login",
                    defaults: new { controller = "Authentication", action = "Login" }
                );

                routes.MapHttpRoute(
                    name: Logout,
                    routeTemplate: "api/auth/logout",
                    defaults: new { controller = "Authentication", action = "Logout" }
                );

                routes.MapHttpRoute(
                    name: Registration,
                    routeTemplate: "api/auth/register",
                    defaults: new { controller = "Authentication", action = "Register" }
                );
            }
        }

        public class Library
        {
            public const string Albums = "Albums";
            public const string AlbumDownload = "DownloadAlbum";
            public const string Artists = "Artists";
            public const string ArtistDownload = "DownloadArtist";
            public const string Genres = "Genres";
            public const string Root = "Library";
            public const string Tracks = "Tracks";
            public const string TrackDownload = "TrackDownload";

            public static void RegisterRoutes(HttpRouteCollection routes)
            {
                routes.MapHttpRoute(
                    name: Root,
                    routeTemplate: "api/library",
                    defaults: new { controller = "Library" }
                );

                routes.MapHttpRoute(
                    name: Albums,
                    routeTemplate: "api/library/albums/{id}",
                    defaults: new { controller = "Albums", id = RouteParameter.Optional }
                );

                routes.MapHttpRoute(
                    name: AlbumDownload,
                    routeTemplate: "api/library/albums/{id}/download",
                    defaults: new { controller = "Download", action = "Album" }
                );

                routes.MapHttpRoute(
                    name: Artists,
                    routeTemplate: "api/library/artists/{artistName}",
                    defaults: new { controller = "Artists", artistName = RouteParameter.Optional }
                );

                routes.MapHttpRoute(
                    name: ArtistDownload,
                    routeTemplate: "api/library/artists/{artistName}/download",
                    defaults: new { controller = "Download", action = "Artist" }
                );

                routes.MapHttpRoute(
                    name: Genres,
                    routeTemplate: "api/library/genres/{genreName}",
                    defaults: new { controller = "Genres", genreName = RouteParameter.Optional }
                );

                routes.MapHttpRoute(
                    name: Tracks,
                    routeTemplate: "api/library/albums/{id}/tracks",
                    defaults: new { controller = "Tracks" }
                );

                routes.MapHttpRoute(
                    name: TrackDownload,
                    routeTemplate: "api/library/tracks/{id}/download",
                    defaults: new { controller = "Download", action = "Track" }
                );
            }
        }
    }
}