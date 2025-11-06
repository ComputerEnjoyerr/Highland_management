using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DTO;

public partial class HighlandsContext : DbContext
{
    public HighlandsContext()
    {
    }

    public HighlandsContext(DbContextOptions<HighlandsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<Billinfo> Billinfos { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<BranchEmployee> BranchEmployees { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Financial> Financials { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<PromotionProduct> PromotionProducts { get; set; }

    public virtual DbSet<PromotionProgram> PromotionPrograms { get; set; }

    public virtual DbSet<PromotionUsage> PromotionUsages { get; set; }

    public virtual DbSet<PromotionVoucher> PromotionVouchers { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<ShiftAssignment> ShiftAssignments { get; set; }

    public virtual DbSet<StockReceipt> StockReceipts { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SupplierIngredient> SupplierIngredients { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<Ward> Wards { get; set; }

    public virtual DbSet<WorkSchedule> WorkSchedules { get; set; }

    public virtual DbSet<WorkShift> WorkShifts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Highlands_Database_ver2;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACCOUNT__3214EC076068B5E1");

            entity.ToTable("ACCOUNT");

            entity.HasIndex(e => e.EmployeeId, "UQ__ACCOUNT__7AD04F1075805AB7").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.AccountName).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.EmployeeId).HasMaxLength(20);
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.Employee).WithOne(p => p.Account)
                .HasForeignKey<Account>(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACCOUNT__Employe__5BE2A6F2");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ADDRESS__3214EC07B0DF7169");

            entity.ToTable("ADDRESS");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.WardId).HasMaxLength(20);

            entity.HasOne(d => d.Ward).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.WardId)
                .HasConstraintName("FK__ADDRESS__WardId__403A8C7D");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ATTENDAN__3214EC07EB673875");

            entity.ToTable("ATTENDANCE");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.ApprovedBy).HasMaxLength(20);
            entity.Property(e => e.BranchId).HasMaxLength(20);
            entity.Property(e => e.CheckIn).HasColumnType("datetime");
            entity.Property(e => e.CheckOut).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(20);
            entity.Property(e => e.Method)
                .HasMaxLength(8)
                .HasDefaultValue("T? d?ng");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.OvertimeHours)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ShiftId).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(20);

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.AttendanceApprovedByNavigations)
                .HasForeignKey(d => d.ApprovedBy)
                .HasConstraintName("FK__ATTENDANC__Appro__4F47C5E3");

            entity.HasOne(d => d.Branch).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__ATTENDANC__Branc__4A8310C6");

            entity.HasOne(d => d.Employee).WithMany(p => p.AttendanceEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__ATTENDANC__Emplo__489AC854");

            entity.HasOne(d => d.Shift).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.ShiftId)
                .HasConstraintName("FK__ATTENDANC__Shift__498EEC8D");
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BILL__3214EC075AF2AF10");

            entity.ToTable("BILL");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.BranchId).HasMaxLength(20);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasMaxLength(20);
            entity.Property(e => e.EmployeeId).HasMaxLength(20);
            entity.Property(e => e.Status).HasDefaultValue(0);

            entity.HasOne(d => d.Branch).WithMany(p => p.Bills)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BILL__BranchId__0E6E26BF");

            entity.HasOne(d => d.Customer).WithMany(p => p.Bills)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BILL__CustomerId__10566F31");

            entity.HasOne(d => d.Employee).WithMany(p => p.Bills)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BILL__EmployeeId__0F624AF8");

            entity.HasOne(d => d.Table).WithMany(p => p.Bills)
                .HasForeignKey(d => d.TableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BILL__TableId__114A936A");
        });

        modelBuilder.Entity<Billinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BILLINFO__3214EC073907A0D2");

            entity.ToTable("BILLINFO");

            entity.Property(e => e.BillId).HasMaxLength(20);
            entity.Property(e => e.ProductId).HasMaxLength(20);

            entity.HasOne(d => d.Bill).WithMany(p => p.Billinfos)
                .HasForeignKey(d => d.BillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BILLINFO__BillId__17F790F9");

            entity.HasOne(d => d.Product).WithMany(p => p.Billinfos)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BILLINFO__Produc__17036CC0");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BRANCH__3214EC072CF2C811");

            entity.ToTable("BRANCH");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.AddressId).HasMaxLength(20);
            entity.Property(e => e.BranchName).HasMaxLength(80);
            entity.Property(e => e.CloseTime).HasPrecision(0);
            entity.Property(e => e.OpenTime).HasPrecision(0);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasMaxLength(20);

            entity.HasOne(d => d.Address).WithMany(p => p.Branches)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK__BRANCH__AddressI__4316F928");
        });

        modelBuilder.Entity<BranchEmployee>(entity =>
        {
            entity.HasKey(e => new { e.EmployeeId, e.BranchId }).HasName("PK__BRANCH_E__30C6CDEDC8243AD1");

            entity.ToTable("BRANCH_EMPLOYEE");

            entity.Property(e => e.EmployeeId).HasMaxLength(20);
            entity.Property(e => e.BranchId).HasMaxLength(20);
            entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Branch).WithMany(p => p.BranchEmployees)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BRANCH_EM__Branc__571DF1D5");

            entity.HasOne(d => d.Employee).WithMany(p => p.BranchEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BRANCH_EM__Emplo__5629CD9C");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CATEGORY__3214EC07B9B65BF5");

            entity.ToTable("CATEGORY");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUSTOMER__3214EC07173F025E");

            entity.ToTable("CUSTOMER");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.CustomerName).HasMaxLength(30);
            entity.Property(e => e.Drips).HasDefaultValue(0);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasDefaultValue("Nam");
            entity.Property(e => e.Phone)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Point)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 0)");
            entity.Property(e => e.Tier)
                .HasMaxLength(10)
                .HasDefaultValue("Member");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EMPLOYEE__3214EC072840BC2B");

            entity.ToTable("EMPLOYEE");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.AddressId).HasMaxLength(20);
            entity.Property(e => e.BranchId).HasMaxLength(20);
            entity.Property(e => e.CitizenId).HasMaxLength(20);
            entity.Property(e => e.CurrentStatus).HasMaxLength(20);
            entity.Property(e => e.EmployeeName).HasMaxLength(30);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasDefaultValue("Nam");
            entity.Property(e => e.HireDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Phone)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(10)
                .HasDefaultValue("Nhân viên");
            entity.Property(e => e.SalaryPerHour).HasColumnType("decimal(8, 0)");

            entity.HasOne(d => d.Address).WithMany(p => p.Employees)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK__EMPLOYEE__Addres__4D94879B");

            entity.HasOne(d => d.Branch).WithMany(p => p.Employees)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EMPLOYEE__Branch__4CA06362");
        });

        modelBuilder.Entity<Financial>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PK__FINANCIA__D5BD48053EC15DE8");

            entity.ToTable("FINANCIAL");

            entity.Property(e => e.ReportId).HasMaxLength(20);
            entity.Property(e => e.BranchId).HasMaxLength(20);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ElectricityCost)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.IngredientCost)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.OtherCost)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.RentCost)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.SalaryCost)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.TotalRevenue)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.WaterCost)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(20, 0)");

            entity.HasOne(d => d.Branch).WithMany(p => p.Financials)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__FINANCIAL__Branc__31B762FC");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INGREDIE__3214EC070C678737");

            entity.ToTable("INGREDIENT");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.IngredientName).HasMaxLength(30);
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => new { e.BranchId, e.IngredientId }).HasName("PK__INVENTOR__1A82C4E04BFE34BF");

            entity.ToTable("INVENTORY");

            entity.Property(e => e.BranchId).HasMaxLength(20);
            entity.Property(e => e.IngredientId).HasMaxLength(20);
            entity.Property(e => e.CurrentQuantity)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(13, 3)");

            entity.HasOne(d => d.Branch).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INVENTORY__Branc__797309D9");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INVENTORY__Ingre__7A672E12");

            entity.HasOne(d => d.Unit).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK__INVENTORY__UnitI__7C4F7684");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NOTIFICA__3214EC072FB40D3D");

            entity.ToTable("NOTIFICATION");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.BranchId).HasMaxLength(20);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(20);
            entity.Property(e => e.IsRead).HasDefaultValue(false);
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.TargetRole).HasMaxLength(20);
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(20);

            entity.HasOne(d => d.Branch).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__NOTIFICAT__Branc__540C7B00");

            entity.HasOne(d => d.Employee).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__NOTIFICAT__Emplo__55009F39");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCTS__3214EC076927FB71");

            entity.ToTable("PRODUCTS");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.CategoryId).HasMaxLength(20);
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValue("Đang bán");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__PRODUCTS__Catego__6477ECF3");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PROMOTIO__3214EC07534BEFA4");

            entity.ToTable("PROMOTION");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.DiscountType).HasMaxLength(12);
            entity.Property(e => e.ExpiryDay).HasDefaultValue(30);
            entity.Property(e => e.MaxDiscount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PromotionName).HasMaxLength(100);
            entity.Property(e => e.PromotionType).HasMaxLength(24);
            entity.Property(e => e.RequiringPoint).HasDefaultValue(0);
            entity.Property(e => e.Value).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<PromotionProduct>(entity =>
        {
            entity.HasKey(e => new { e.PromotionId, e.ProductId, e.BranchId }).HasName("PK__PROMOTIO__5D258B8C4704214F");

            entity.ToTable("PROMOTION_PRODUCT");

            entity.Property(e => e.PromotionId).HasMaxLength(20);
            entity.Property(e => e.ProductId).HasMaxLength(20);
            entity.Property(e => e.BranchId).HasMaxLength(20);
            entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Branch).WithMany(p => p.PromotionProducts)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Branc__22751F6C");

            entity.HasOne(d => d.Product).WithMany(p => p.PromotionProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Produ__2180FB33");

            entity.HasOne(d => d.Promotion).WithMany(p => p.PromotionProducts)
                .HasForeignKey(d => d.PromotionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Promo__208CD6FA");
        });

        modelBuilder.Entity<PromotionProgram>(entity =>
        {
            entity.HasKey(e => e.PromotionId).HasName("PK__PROMOTIO__52C42FCFA29476E7");

            entity.ToTable("PROMOTION_PROGRAM");

            entity.Property(e => e.PromotionId).HasMaxLength(20);
            entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Promotion).WithOne(p => p.PromotionProgram)
                .HasForeignKey<PromotionProgram>(d => d.PromotionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Promo__2A164134");
        });

        modelBuilder.Entity<PromotionUsage>(entity =>
        {
            entity.HasKey(e => new { e.PromotionId, e.BillId }).HasName("PK__PROMOTIO__E3DB000907E009BA");

            entity.ToTable("PROMOTION_USAGE");

            entity.Property(e => e.PromotionId).HasMaxLength(20);
            entity.Property(e => e.BillId).HasMaxLength(20);
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(10, 0)");

            entity.HasOne(d => d.Bill).WithMany(p => p.PromotionUsages)
                .HasForeignKey(d => d.BillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__BillI__2EDAF651");

            entity.HasOne(d => d.Promotion).WithMany(p => p.PromotionUsages)
                .HasForeignKey(d => d.PromotionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Promo__2DE6D218");
        });

        modelBuilder.Entity<PromotionVoucher>(entity =>
        {
            entity.HasKey(e => new { e.PromotionId, e.CustomerId }).HasName("PK__PROMOTIO__C88EC98274649327");

            entity.ToTable("PROMOTION_VOUCHER");

            entity.Property(e => e.PromotionId).HasMaxLength(20);
            entity.Property(e => e.CustomerId).HasMaxLength(20);

            entity.HasOne(d => d.Customer).WithMany(p => p.PromotionVouchers)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Custo__2739D489");

            entity.HasOne(d => d.Promotion).WithMany(p => p.PromotionVouchers)
                .HasForeignKey(d => d.PromotionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Promo__2645B050");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PROVINCE__3214EC070E3E3FD1");

            entity.ToTable("PROVINCE");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.CodeName).HasMaxLength(3);
            entity.Property(e => e.ProvinceName).HasMaxLength(30);
            entity.Property(e => e.Type)
                .HasMaxLength(31)
                .HasDefaultValue("Tỉnh");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECIPE__3214EC0742CF62D4");

            entity.ToTable("RECIPE");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.IngredientId).HasMaxLength(20);
            entity.Property(e => e.ProductId).HasMaxLength(20);
            entity.Property(e => e.Quantity)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECIPE__Ingredie__73BA3083");

            entity.HasOne(d => d.Product).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECIPE__ProductI__74AE54BC");

            entity.HasOne(d => d.RecipeUnit).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.RecipeUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECIPE__RecipeUn__76969D2E");
        });

        modelBuilder.Entity<ShiftAssignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SHIFT_AS__3214EC07B93839D5");

            entity.ToTable("SHIFT_ASSIGNMENT");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.EmployeeId).HasMaxLength(20);
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.ShiftId).HasMaxLength(20);

            entity.HasOne(d => d.Employee).WithMany(p => p.ShiftAssignments)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__SHIFT_ASS__Emplo__45BE5BA9");

            entity.HasOne(d => d.Shift).WithMany(p => p.ShiftAssignments)
                .HasForeignKey(d => d.ShiftId)
                .HasConstraintName("FK__SHIFT_ASS__Shift__44CA3770");
        });

        modelBuilder.Entity<StockReceipt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STOCK_RE__3214EC07AC422925");

            entity.ToTable("STOCK_RECEIPT");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.BranchId).HasMaxLength(20);
            entity.Property(e => e.CreatedBy).HasMaxLength(20);
            entity.Property(e => e.IngredientId).HasMaxLength(20);
            entity.Property(e => e.ReceiptDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.SupplierId).HasMaxLength(20);
            entity.Property(e => e.TotalPrice)
                .HasComputedColumnSql("([Quantity]*[UnitPrice])", false)
                .HasColumnType("decimal(31, 0)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(20, 0)");

            entity.HasOne(d => d.Branch).WithMany(p => p.StockReceipts)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__STOCK_REC__Branc__7F2BE32F");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StockReceipts)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__STOCK_REC__Creat__02084FDA");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.StockReceipts)
                .HasForeignKey(d => d.IngredientId)
                .HasConstraintName("FK__STOCK_REC__Ingre__00200768");

            entity.HasOne(d => d.PurchasedUnit).WithMany(p => p.StockReceipts)
                .HasForeignKey(d => d.PurchasedUnitId)
                .HasConstraintName("FK__STOCK_REC__Purch__02FC7413");

            entity.HasOne(d => d.Supplier).WithMany(p => p.StockReceipts)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK__STOCK_REC__Suppl__01142BA1");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SUPPLIER__3214EC079D66599C");

            entity.ToTable("SUPPLIER");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.AddressId).HasMaxLength(20);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Address).WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK__SUPPLIER__Addres__5FB337D6");
        });

        modelBuilder.Entity<SupplierIngredient>(entity =>
        {
            entity.HasKey(e => new { e.SupplierId, e.IngredientId }).HasName("PK__SUPPLIER__F00C8D911416AA19");

            entity.ToTable("SUPPLIER_INGREDIENT");

            entity.Property(e => e.SupplierId).HasMaxLength(20);
            entity.Property(e => e.IngredientId).HasMaxLength(20);
            entity.Property(e => e.ExpiryDay).HasDefaultValue(30);
            entity.Property(e => e.ProducedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(10, 0)");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.SupplierIngredients)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SUPPLIER___Ingre__6E01572D");

            entity.HasOne(d => d.StandardUnit).WithMany(p => p.SupplierIngredients)
                .HasForeignKey(d => d.StandardUnitId)
                .HasConstraintName("FK__SUPPLIER___Stand__6EF57B66");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SupplierIngredients)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SUPPLIER___Suppl__6D0D32F4");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TABLES__3214EC07116BD810");

            entity.ToTable("TABLES");

            entity.Property(e => e.BranchId).HasMaxLength(20);
            entity.Property(e => e.Capacity).HasDefaultValue(4);
            entity.Property(e => e.Status).HasDefaultValue(0);
            entity.Property(e => e.TableName).HasMaxLength(10);

            entity.HasOne(d => d.Branch).WithMany(p => p.Tables)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TABLES__BranchId__46E78A0C");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UNIT__3214EC07D52CF248");

            entity.ToTable("UNIT");

            entity.Property(e => e.UnitName).HasMaxLength(20);
        });

        modelBuilder.Entity<Ward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WARD__3214EC074696323B");

            entity.ToTable("WARD");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.ProvinceId).HasMaxLength(20);
            entity.Property(e => e.Type)
                .HasMaxLength(7)
                .HasDefaultValue("Phường");
            entity.Property(e => e.WardName).HasMaxLength(30);

            entity.HasOne(d => d.Province).WithMany(p => p.Wards)
                .HasForeignKey(d => d.ProvinceId)
                .HasConstraintName("FK__WARD__ProvinceId__3B75D760");
        });

        modelBuilder.Entity<WorkSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WORK_SCH__3214EC0778125420");

            entity.ToTable("WORK_SCHEDULE");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.BranchId).HasMaxLength(20);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(20);

            entity.HasOne(d => d.Branch).WithMany(p => p.WorkSchedules)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__WORK_SCHE__Branc__3C34F16F");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.WorkSchedules)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__WORK_SCHE__Creat__3D2915A8");
        });

        modelBuilder.Entity<WorkShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WORK_SHI__3214EC072F3B1711");

            entity.ToTable("WORK_SHIFT");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.ScheduleId).HasMaxLength(20);
            entity.Property(e => e.ShiftType).HasMaxLength(20);

            entity.HasOne(d => d.Schedule).WithMany(p => p.WorkShifts)
                .HasForeignKey(d => d.ScheduleId)
                .HasConstraintName("FK__WORK_SHIF__Sched__40F9A68C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
