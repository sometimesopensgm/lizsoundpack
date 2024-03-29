﻿using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace LizOverhaul.Content.Items.Ammo
{
	public class PopBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Splits and bounces, has friction"); // The item's description, can be set to whatever you want.

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 99;
		}

		public override void SetDefaults()
		{
			Item.damage = 6; // The damage for projectiles isn't actually 12, it actually is the damage combined with the projectile and the item together.
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 999;
			Item.consumable = true; // This marks the item as consumable, making it automatically be consumed when it's used as ammunition, or something else, if possible.
			Item.knockBack = 1.5f;
			Item.value = 10;
			Item.rare = ItemRarityID.Green;
			Item.shoot = ModContent.ProjectileType<Projectiles.PopBullet>(); // The projectile that weapons fire when using this item as ammunition.
			Item.shootSpeed = 12f; // The speed of the projectile.
			Item.ammo = AmmoID.Bullet; // The ammo class this ammo belongs to.
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.EmptyBullet)
				.AddIngredient(ItemID.MusketBall,2)
				.Register();
		}
	}
}
