﻿using System.Data.Entity;

namespace BestFitBusinessLayer.Models
{
	public class BestFitPCBContext : DbContext
	{

		public BestFitPCBContext()
			: base("Name=BestFitPcbContext")
		{
		}

		public DbSet<arraySpacing> arraySpacings { get; set; }
		public DbSet<company> companies { get; set; }
		public DbSet<companyProfile> companyProfiles { get; set; }
		public DbSet<companyUser> companyUsers { get; set; }
		public DbSet<cupon> cupons { get; set; }
		public DbSet<drowingColor> drowingColors { get; set; }
		public DbSet<panelSize> panelSizes { get; set; }
		public DbSet<panelSpacing> panelSpacings { get; set; }
		public DbSet<panelTooling> panelToolings { get; set; }
		public DbSet<UserProfile> UserProfiles { get; set; }
		public DbSet<webpages_Membership> webpages_Membership { get; set; }
		public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
		public DbSet<webpages_Roles> webpages_Roles { get; set; }

	}
}
