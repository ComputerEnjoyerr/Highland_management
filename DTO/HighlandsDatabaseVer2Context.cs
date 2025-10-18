using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DTO;

public partial class HighlandsDatabaseVer2Context : DbContext
{
    public HighlandsDatabaseVer2Context()
    {
    }

    public HighlandsDatabaseVer2Context(DbContextOptions<HighlandsDatabaseVer2Context> options)
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
            entity.HasKey(e => e.Id).HasName("PK__ACCOUNT__3214EC07A48AF795");

            entity.ToTable("ACCOUNT");

            entity.HasIndex(e => e.EmployeeId, "UQ__ACCOUNT__7AD04F10670070E6").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(14);
            entity.Property(e => e.AccountName).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.EmployeeId).HasMaxLength(10);
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.Employee).WithOne(p => p.Account)
                .HasForeignKey<Account>(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACCOUNT__Employe__59063A47");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ADDRESS__3214EC072D5D5788");

            entity.ToTable("ADDRESS");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .HasColumnName("Address");
            entity.Property(e => e.WardId).HasMaxLength(20);

            entity.HasOne(d => d.Ward).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.WardId)
                .HasConstraintName("FK__ADDRESS__WardId__403A8C7D");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ATTENDAN__3214EC07646F2053");

            entity.ToTable("ATTENDANCE");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.ApprovedBy).HasMaxLength(10);
            entity.Property(e => e.BranchId).HasMaxLength(10);
            entity.Property(e => e.CheckIn).HasColumnType("datetime");
            entity.Property(e => e.CheckOut).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(10);
            entity.Property(e => e.Method)
                .HasMaxLength(8)
                .HasDefaultValue("T? d?ng");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.ShiftId).HasMaxLength(14);
            entity.Property(e => e.Status).HasMaxLength(20);

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.AttendanceApprovedByNavigations)
                .HasForeignKey(d => d.ApprovedBy)
                .HasConstraintName("FK__ATTENDANC__Appro__43D61337");

            entity.HasOne(d => d.Branch).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__ATTENDANC__Branc__40058253");

            entity.HasOne(d => d.Employee).WithMany(p => p.AttendanceEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__ATTENDANC__Emplo__3E1D39E1");

            entity.HasOne(d => d.Shift).WithMany(p => p.Attendances)
                .HasForeignKey(d => d.ShiftId)
                .HasConstraintName("FK__ATTENDANC__Shift__3F115E1A");
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BILL__3214EC07DD6886F4");

            entity.ToTable("BILL");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.BranchId).HasMaxLength(10);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasMaxLength(12);
            entity.Property(e => e.EmployeeId).HasMaxLength(10);
            entity.Property(e => e.Status).HasDefaultValue(0);

            entity.HasOne(d => d.Branch).WithMany(p => p.Bills)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BILL__BranchId__03F0984C");

            entity.HasOne(d => d.Customer).WithMany(p => p.Bills)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BILL__CustomerId__05D8E0BE");

            entity.HasOne(d => d.Employee).WithMany(p => p.Bills)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BILL__EmployeeId__04E4BC85");

            entity.HasOne(d => d.Table).WithMany(p => p.Bills)
                .HasForeignKey(d => d.TableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BILL__TableId__06CD04F7");
        });

        modelBuilder.Entity<Billinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BILLINFO__3214EC07786F51D8");

            entity.ToTable("BILLINFO");

            entity.Property(e => e.BillId).HasMaxLength(20);
            entity.Property(e => e.ProductId).HasMaxLength(14);

            entity.HasOne(d => d.Bill).WithMany(p => p.Billinfos)
                .HasForeignKey(d => d.BillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BILLINFO__BillId__0D7A0286");

            entity.HasOne(d => d.Product).WithMany(p => p.Billinfos)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BILLINFO__Produc__0C85DE4D");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BRANCH__3214EC0767599046");

            entity.ToTable("BRANCH");

            entity.Property(e => e.Id).HasMaxLength(10);
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
            entity.HasKey(e => new { e.EmployeeId, e.BranchId }).HasName("PK__BRANCH_E__30C6CDED1D8B835C");

            entity.ToTable("BRANCH_EMPLOYEE");

            entity.Property(e => e.EmployeeId).HasMaxLength(10);
            entity.Property(e => e.BranchId).HasMaxLength(10);
            entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Branch).WithMany(p => p.BranchEmployees)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BRANCH_EM__Branc__5441852A");

            entity.HasOne(d => d.Employee).WithMany(p => p.BranchEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BRANCH_EM__Emplo__534D60F1");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CATEGORY__3214EC07F16FAF3A");

            entity.ToTable("CATEGORY");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUSTOMER__3214EC07095FF384");

            entity.ToTable("CUSTOMER");

            entity.Property(e => e.Id).HasMaxLength(12);
            entity.Property(e => e.CustomerName).HasMaxLength(30);
            entity.Property(e => e.Drips).HasDefaultValue(0);
            entity.Property(e => e.Email).HasMaxLength(50);
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
            entity.HasKey(e => e.Id).HasName("PK__EMPLOYEE__3214EC07527A0E68");

            entity.ToTable("EMPLOYEE");

            entity.Property(e => e.Id).HasMaxLength(10);
            entity.Property(e => e.AddressId).HasMaxLength(20);
            entity.Property(e => e.BranchId).HasMaxLength(10);
            entity.Property(e => e.EmployeeName).HasMaxLength(30);
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
            entity.HasKey(e => e.ReportId).HasName("PK__FINANCIA__D5BD4805970948BE");

            entity.ToTable("FINANCIAL");

            entity.Property(e => e.ReportId).HasMaxLength(16);
            entity.Property(e => e.BranchId).HasMaxLength(10);
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
                .HasConstraintName("FK__FINANCIAL__Branc__282DF8C2");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INGREDIE__3214EC075CD1476A");

            entity.ToTable("INGREDIENT");

            entity.Property(e => e.Id).HasMaxLength(14);
            entity.Property(e => e.IngredientName).HasMaxLength(30);
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => new { e.BranchId, e.IngredientId }).HasName("PK__INVENTOR__1A82C4E09C51B55E");

            entity.ToTable("INVENTORY");

            entity.Property(e => e.BranchId).HasMaxLength(10);
            entity.Property(e => e.IngredientId).HasMaxLength(14);
            entity.Property(e => e.CurrentQuantity)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(13, 3)");

            entity.HasOne(d => d.Branch).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INVENTORY__Branc__72C60C4A");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INVENTORY__Ingre__73BA3083");

            entity.HasOne(d => d.Unit).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK__INVENTORY__UnitI__75A278F5");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NOTIFICA__3214EC0710F7930F");

            entity.ToTable("NOTIFICATION");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.BranchId).HasMaxLength(10);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(10);
            entity.Property(e => e.IsRead).HasDefaultValue(false);
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.TargetRole).HasMaxLength(20);
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(20);

            entity.HasOne(d => d.Branch).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__NOTIFICAT__Branc__489AC854");

            entity.HasOne(d => d.Employee).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__NOTIFICAT__Emplo__498EEC8D");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCTS__3214EC0775BA4BAE");

            entity.ToTable("PRODUCTS");

            entity.Property(e => e.Id).HasMaxLength(14);
            entity.Property(e => e.CategoryId).HasMaxLength(20);
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.ProductName).HasMaxLength(50);

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__PRODUCTS__Catego__619B8048");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PROMOTIO__3214EC07B670DB2E");

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
            entity.HasKey(e => new { e.PromotionId, e.ProductId, e.BranchId }).HasName("PK__PROMOTIO__5D258B8C45C254F1");

            entity.ToTable("PROMOTION_PRODUCT");

            entity.Property(e => e.PromotionId).HasMaxLength(20);
            entity.Property(e => e.ProductId).HasMaxLength(14);
            entity.Property(e => e.BranchId).HasMaxLength(10);
            entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Branch).WithMany(p => p.PromotionProducts)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Branc__17F790F9");

            entity.HasOne(d => d.Product).WithMany(p => p.PromotionProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Produ__17036CC0");

            entity.HasOne(d => d.Promotion).WithMany(p => p.PromotionProducts)
                .HasForeignKey(d => d.PromotionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Promo__160F4887");
        });

        modelBuilder.Entity<PromotionProgram>(entity =>
        {
            entity.HasKey(e => e.PromotionId).HasName("PK__PROMOTIO__52C42FCF5E79B70B");

            entity.ToTable("PROMOTION_PROGRAM");

            entity.Property(e => e.PromotionId).HasMaxLength(20);
            entity.Property(e => e.CategoryId).HasMaxLength(20);
            entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Category).WithMany(p => p.PromotionPrograms)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__PROMOTION__Categ__208CD6FA");

            entity.HasOne(d => d.Promotion).WithOne(p => p.PromotionProgram)
                .HasForeignKey<PromotionProgram>(d => d.PromotionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Promo__1F98B2C1");
        });

        modelBuilder.Entity<PromotionUsage>(entity =>
        {
            entity.HasKey(e => new { e.PromotionId, e.BillId }).HasName("PK__PROMOTIO__E3DB0009C2EE55E4");

            entity.ToTable("PROMOTION_USAGE");

            entity.Property(e => e.PromotionId).HasMaxLength(20);
            entity.Property(e => e.BillId).HasMaxLength(20);
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(10, 0)");

            entity.HasOne(d => d.Bill).WithMany(p => p.PromotionUsages)
                .HasForeignKey(d => d.BillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__BillI__25518C17");

            entity.HasOne(d => d.Promotion).WithMany(p => p.PromotionUsages)
                .HasForeignKey(d => d.PromotionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Promo__245D67DE");
        });

        modelBuilder.Entity<PromotionVoucher>(entity =>
        {
            entity.HasKey(e => new { e.PromotionId, e.CustomerId }).HasName("PK__PROMOTIO__C88EC9823474995C");

            entity.ToTable("PROMOTION_VOUCHER");

            entity.Property(e => e.PromotionId).HasMaxLength(20);
            entity.Property(e => e.CustomerId).HasMaxLength(12);

            entity.HasOne(d => d.Customer).WithMany(p => p.PromotionVouchers)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Custo__1CBC4616");

            entity.HasOne(d => d.Promotion).WithMany(p => p.PromotionVouchers)
                .HasForeignKey(d => d.PromotionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PROMOTION__Promo__1BC821DD");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PROVINCE__3214EC077D98F629");

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
            entity.HasKey(e => e.Id).HasName("PK__RECIPE__3214EC07ED948F5C");

            entity.ToTable("RECIPE");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.IngredientId).HasMaxLength(14);
            entity.Property(e => e.ProductId).HasMaxLength(14);
            entity.Property(e => e.Quantity)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(10, 3)");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECIPE__Ingredie__6D0D32F4");

            entity.HasOne(d => d.Product).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECIPE__ProductI__6E01572D");

            entity.HasOne(d => d.RecipeUnit).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.RecipeUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECIPE__RecipeUn__6FE99F9F");
        });

        modelBuilder.Entity<ShiftAssignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SHIFT_AS__3214EC075A631DEA");

            entity.ToTable("SHIFT_ASSIGNMENT");

            entity.Property(e => e.Id).HasMaxLength(14);
            entity.Property(e => e.EmployeeId).HasMaxLength(10);
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.ShiftId).HasMaxLength(14);

            entity.HasOne(d => d.Employee).WithMany(p => p.ShiftAssignments)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__SHIFT_ASS__Emplo__3B40CD36");

            entity.HasOne(d => d.Shift).WithMany(p => p.ShiftAssignments)
                .HasForeignKey(d => d.ShiftId)
                .HasConstraintName("FK__SHIFT_ASS__Shift__3A4CA8FD");
        });

        modelBuilder.Entity<StockReceipt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STOCK_RE__3214EC07264D3B5C");

            entity.ToTable("STOCK_RECEIPT");

            entity.Property(e => e.Id).HasMaxLength(14);
            entity.Property(e => e.BranchId).HasMaxLength(10);
            entity.Property(e => e.IngredientId).HasMaxLength(14);
            entity.Property(e => e.ReceiptkDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.TotalPrice)
                .HasComputedColumnSql("([Quantity]*[UnitPrice])", false)
                .HasColumnType("decimal(31, 0)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(20, 0)");

            entity.HasOne(d => d.Branch).WithMany(p => p.StockReceipts)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__STOCK_REC__Branc__787EE5A0");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.StockReceipts)
                .HasForeignKey(d => d.IngredientId)
                .HasConstraintName("FK__STOCK_REC__Ingre__797309D9");

            entity.HasOne(d => d.PurchasedUnit).WithMany(p => p.StockReceipts)
                .HasForeignKey(d => d.PurchasedUnitId)
                .HasConstraintName("FK__STOCK_REC__Purch__7A672E12");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SUPPLIER__3214EC073DF29257");

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
                .HasConstraintName("FK__SUPPLIER__Addres__5CD6CB2B");
        });

        modelBuilder.Entity<SupplierIngredient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SUPPLIER_INGREDIENT");

            entity.Property(e => e.ExpiryDay).HasDefaultValue(30);
            entity.Property(e => e.IngredientId).HasMaxLength(14);
            entity.Property(e => e.SupplierId).HasMaxLength(20);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(10, 0)");

            entity.HasOne(d => d.Ingredient).WithMany()
                .HasForeignKey(d => d.IngredientId)
                .HasConstraintName("FK__SUPPLIER___Ingre__68487DD7");

            entity.HasOne(d => d.StandardUnit).WithMany()
                .HasForeignKey(d => d.StandardUnitId)
                .HasConstraintName("FK__SUPPLIER___Stand__693CA210");

            entity.HasOne(d => d.Supplier).WithMany()
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK__SUPPLIER___Suppl__6754599E");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TABLES__3214EC07DC89FE05");

            entity.ToTable("TABLES");

            entity.Property(e => e.BranchId).HasMaxLength(10);
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
            entity.HasKey(e => e.Id).HasName("PK__UNIT__3214EC0721AFC05A");

            entity.ToTable("UNIT");

            entity.Property(e => e.UnitName).HasMaxLength(20);
        });

        modelBuilder.Entity<Ward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WARD__3214EC07FC463566");

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
            entity.HasKey(e => e.Id).HasName("PK__WORK_SCH__3214EC0726CA418E");

            entity.ToTable("WORK_SCHEDULE");

            entity.Property(e => e.Id).HasMaxLength(14);
            entity.Property(e => e.BranchId).HasMaxLength(10);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(10);

            entity.HasOne(d => d.Branch).WithMany(p => p.WorkSchedules)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__WORK_SCHE__Branc__31B762FC");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.WorkSchedules)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__WORK_SCHE__Creat__32AB8735");
        });

        modelBuilder.Entity<WorkShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WORK_SHI__3214EC0727B6F5D9");

            entity.ToTable("WORK_SHIFT");

            entity.Property(e => e.Id).HasMaxLength(14);
            entity.Property(e => e.ScheduleId).HasMaxLength(14);
            entity.Property(e => e.ShiftType).HasMaxLength(20);

            entity.HasOne(d => d.Schedule).WithMany(p => p.WorkShifts)
                .HasForeignKey(d => d.ScheduleId)
                .HasConstraintName("FK__WORK_SHIF__Sched__367C1819");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
