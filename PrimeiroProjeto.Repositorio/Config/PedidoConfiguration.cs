using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeiroProjeto.Dominio.Entidades;
using System;

namespace PrimeiroProjeto.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(p => p.DataPedido)
                .IsRequired();

            builder.Property(p => p.DataPrevisaoEntrega)
                .IsRequired();

            builder.Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.NumeroEndereco)
                .IsRequired()
                .HasMaxLength(10);


        }
    }
}
