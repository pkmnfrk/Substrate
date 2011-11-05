﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Substrate.Entities
{
    using Substrate.Nbt;

    public class EntityMagmaCube : EntitySlime
    {
        public static readonly SchemaNodeCompound MagmaCubeSchema = SlimeSchema.MergeInto(new SchemaNodeCompound("")
        {
            new SchemaNodeString("id", "LavaSlime"),
        });

        public EntityMagmaCube ()
            : base("LavaSlime")
        {
        }

        public EntityMagmaCube (TypedEntity e)
            : base(e)
        {
        }


        #region INBTObject<Entity> Members

        public override bool ValidateTree (TagNode tree)
        {
            return new NbtVerifier(tree, MagmaCubeSchema).Verify();
        }

        #endregion


        #region ICopyable<Entity> Members

        public override TypedEntity Copy ()
        {
            return new EntityMagmaCube(this);
        }

        #endregion
    }
}
