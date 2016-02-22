﻿namespace PartyMate.Web.Areas.Api.Models.HiddenImage
{
    using PartyMate.Data.Models;
    using PartyMate.Web.Infrastructure.Mapping;

    public class HiddenImageViewModel : IMapFrom<ClubHiddenImage>
    {
        public byte[] Content { get; set; }
    }
}