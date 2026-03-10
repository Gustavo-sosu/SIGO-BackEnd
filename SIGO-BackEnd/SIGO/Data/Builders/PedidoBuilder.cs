using Microsoft.EntityFrameworkCore;
using SIGO.Objects.Models;

namespace SIGO.Data.Builders
{
    public class PedidoBuilder
    {
        public static void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>().HasKey(p => p.Id);

            modelBuilder.Entity<Pedido>().Property(p => p.ValorTotal).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.DescontoReais).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.DescontoPorcentagem).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.DescontoTotalReais).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.DescontoServicoPorcentagem).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.DescontoServicoReais).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.DescontoPecaPorcentagem).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.descontoPecaReais).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.Observacao).HasMaxLength(500);
            modelBuilder.Entity<Pedido>().Property(p => p.DataInicio).IsRequired();
            modelBuilder.Entity<Pedido>().Property(p => p.DataFim).IsRequired();

            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.idCliente)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Funcionario)
                .WithMany()
                .HasForeignKey(p => p.idFuncionario)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Oficina)
                .WithMany()
                .HasForeignKey(p => p.idOficina)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Veiculo)
                .WithMany()
                .HasForeignKey(p => p.idVeiculo)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
