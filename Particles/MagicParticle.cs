﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent;
using System;
using LizSoundPack.Content.Effects;

namespace LizSoundPack.Content.Effects
{
    public class MagicParticle : Particle
    {
        public bool alt;
        public override void Init()
        {
            if (!alt)
            {
                texture = (Texture2D)ModContent.Request<Texture2D>("LizSoundPack/Particles/MagicEffect");
                frameMax = 8;
                frameDuration = 1 + Main.rand.Next(2);
                frame = new Rectangle(0, 0, texture.Width, texture.Height / frameMax);
                origin = origin_center(texture);
                rotation = Main.rand.NextFloat((float)Math.PI);
            }
            else
            {
                {
                    texture = (Texture2D)ModContent.Request<Texture2D>("LizSoundPack/Particles/MagicEffectAlt");
                    frameMax = 9;
                    frameDuration = 1 + Main.rand.Next(2);
                    frame = new Rectangle(0, 0, texture.Width, texture.Height / frameMax);
                    origin = origin_center(texture);
                    rotation = Main.rand.NextFloat((float)Math.PI);
                }
            }
        }

        public override void Draw(SpriteBatch sb)
        {
            base.Draw(sb);
            if (texture != null)
            {
                for (var j = 0; j < 12; j++)
                {
                    Vector2 rand = Main.rand.NextVector2Square(-j / 2, j / 2);
                    Draw_Sprite(sb, texture, frame, position+rand, origin, scale * (1f + 0.03f * j), rotation, color, 0.15f);
                }
            }
        }
    }
}