﻿using EarthWithMagicAPI.API.Util;

namespace EarthMagicItems.Ammo.Arrows.Normal
{
    /// <summary>
    /// A enchanted +1 arrow.
    /// </summary>
    public class _1Arrow : GenericAmmo
    {
        public _1Arrow()
            : base(new Die(2, 4, 0), "+1 Arrow", AmmoUtil.StandardArrow(new Die(1, 8, 1)), "EarthMagicDocumentation.ASCII_Art.Items.Ammo.Arrows.ProfessionalArrow.txt",
            "EarthMagicDocumentation.Items.Ammo.Arrows.+1Arrow.md", .2)
        {
        }
    }
}