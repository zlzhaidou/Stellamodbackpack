﻿

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ParticleLibrary;
using Stellamod.Helpers;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace Stellamod.Particles
{
    public class BLACKHOLETEST : Particle
    {
        private const bool V = true;
        private int frameCount;
        private int frameTick;
        private bool ProjDed;

        public override void SetDefaults()
        {
            width = 1;
            height = 1;
            Scale = 2f;
            timeLeft = 1000000;
        }

        public override void AI()
        {
            Player player = Main.LocalPlayer;
            rotation += 0.4f;

            position = Main.projectile[(int)ai[0]].Center;
            if (!Main.projectile[(int)ai[0]].active)
            {
                if (!ProjDed)
                {
                    timeLeft = 5;
                }
                ProjDed = true;






                color = Color.Lerp(new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB, 0f), Color.Multiply(new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB, 0f), 0.5f), (360f - timeLeft) / 360f);
            }
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Vector2 screenPos, Color lightColor)
        {

            Texture2D tex3 = Request<Texture2D>("Stellamod/Particles/BLACKHOLETEST").Value;

            float alpha = timeLeft <= 20 ? 1f - 1f / 20f * (20 - timeLeft) : 1f;
            if (alpha < 0f) alpha = 0f;
            Color color = Color.Multiply(new(2.55f, 1.25f, 0.24f, 0), alpha / 2);
            spriteBatch.Draw(tex3, Bottom - Main.screenPosition, tex3.AnimationFrame(ref frameCount, ref frameTick, 1, 90, true), color, velocity.ToRotation() + 180, new Vector2(270f, 249f) * 0.5f, 1.35f * scale, SpriteEffects.None, 0f);
            return false;
        }
    }
}