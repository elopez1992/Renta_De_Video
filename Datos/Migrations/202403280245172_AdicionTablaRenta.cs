namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionTablaRenta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rentas",
                c => new
                    {
                        RentaId = c.Int(nullable: false, identity: true),
                        ClienteId = c.String(nullable: false, maxLength: 75),
                        PeliculaId = c.String(nullable: false, maxLength: 75),
                        FechaRenta = c.DateTime(nullable: false),
                        FechaRetorno = c.DateTime(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        PrecioRenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Clientes_ClienteId = c.Int(),
                        Peliculas_PeliculaId = c.Int(),
                    })
                .PrimaryKey(t => t.RentaId)
                .ForeignKey("dbo.Clientes", t => t.Clientes_ClienteId)
                .ForeignKey("dbo.Peliculas", t => t.Peliculas_PeliculaId)
                .Index(t => t.Clientes_ClienteId)
                .Index(t => t.Peliculas_PeliculaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentas", "Peliculas_PeliculaId", "dbo.Peliculas");
            DropForeignKey("dbo.Rentas", "Clientes_ClienteId", "dbo.Clientes");
            DropIndex("dbo.Rentas", new[] { "Peliculas_PeliculaId" });
            DropIndex("dbo.Rentas", new[] { "Clientes_ClienteId" });
            DropTable("dbo.Rentas");
        }
    }
}
