using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using KSS.Entity;

namespace KSS.Data.Configuration
{
    public class MarketTypeConfiguration : IEntityTypeConfiguration<MarketType>
    {
        public void Configure(EntityTypeBuilder<MarketType> b)
        {
            b.Property(x => x.IsActive).HasDefaultValue(true);
            b.HasIndex(x => x.Code).IsUnique();
            b.HasMany(x => x.Translations).WithOne(x => x.MarketType).HasForeignKey(x => x.MarketTypeId).OnDelete(DeleteBehavior.Cascade);
            b.HasMany(x => x.Assets).WithOne(x => x.MarketType).HasForeignKey(x => x.MarketTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class MarketTypeTranslationConfiguration : IEntityTypeConfiguration<MarketTypeTranslation>
    {
        public void Configure(EntityTypeBuilder<MarketTypeTranslation> b)
        {
            b.HasKey(x => new { x.MarketTypeId, x.LanguageId });
        }
    }

    public class AssetTypeConfiguration : IEntityTypeConfiguration<AssetType>
    {
        public void Configure(EntityTypeBuilder<AssetType> b)
        {
            b.Property(x => x.IsActive).HasDefaultValue(true);
            b.HasIndex(x => x.Code).IsUnique();
            b.HasMany(x => x.Translations).WithOne(x => x.AssetType).HasForeignKey(x => x.AssetTypeId).OnDelete(DeleteBehavior.Cascade);
            b.HasMany(x => x.Assets).WithOne(x => x.AssetType).HasForeignKey(x => x.AssetTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class AssetTypeTranslationConfiguration : IEntityTypeConfiguration<AssetTypeTranslation>
    {
        public void Configure(EntityTypeBuilder<AssetTypeTranslation> b)
        {
            b.HasKey(x => new { x.AssetTypeId, x.LanguageId });
        }
    }

    public class SectorConfiguration : IEntityTypeConfiguration<Sector>
    {
        public void Configure(EntityTypeBuilder<Sector> b)
        {
            b.Property(x => x.IsActive).HasDefaultValue(true);
            b.HasIndex(x => x.Code).IsUnique();
            b.HasMany(x => x.Translations).WithOne(x => x.Sector).HasForeignKey(x => x.SectorId).OnDelete(DeleteBehavior.Cascade);
            b.HasMany(x => x.Assets).WithOne(x => x.Sector).HasForeignKey(x => x.SectorId).OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class SectorTranslationConfiguration : IEntityTypeConfiguration<SectorTranslation>
    {
        public void Configure(EntityTypeBuilder<SectorTranslation> b)
        {
            b.HasKey(x => new { x.SectorId, x.LanguageId });
        }
    }

    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> b)
        {
            b.HasOne(x => x.MarketType).WithMany(x => x.Assets).HasForeignKey(x => x.MarketTypeId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne(x => x.AssetType).WithMany(x => x.Assets).HasForeignKey(x => x.AssetTypeId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne(x => x.Sector).WithMany(x => x.Assets).HasForeignKey(x => x.SectorId).OnDelete(DeleteBehavior.Restrict);
            b.HasMany(x => x.Translations).WithOne(x => x.Asset).HasForeignKey(x => x.AssetId).OnDelete(DeleteBehavior.Cascade);
            b.HasIndex(x => new { x.Symbol, x.MarketTypeId }).IsUnique();
        }
    }

    public class AssetTranslationConfiguration : IEntityTypeConfiguration<AssetTranslation>
    {
        public void Configure(EntityTypeBuilder<AssetTranslation> b)
        {
            b.HasKey(x => new { x.AssetId, x.LanguageId });
        }
    }
}
