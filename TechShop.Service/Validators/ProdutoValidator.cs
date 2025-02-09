using TechShop.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Service.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(c => c.Nome)
               .NotEmpty().WithMessage("Por favor, informe o nome do Produto.")
               .NotNull().NotEmpty().WithMessage("Por favor, informe o nome do Produto.")
               .MaximumLength(100).WithMessage("Muito Extenso! O Nome pode ter no máximo 100 caracteres.");
            RuleFor(c => c.Modelo)
               .NotEmpty().WithMessage("Por favor, informe o modelo.")
               .NotNull().NotEmpty().WithMessage("Por favor, informe o modelo.");
            RuleFor(c => c.Preco)
              .NotEmpty().WithMessage("Por favor, informe o preço.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe o preço.");
            RuleFor(c => c.Fabricante)
               .NotEmpty().WithMessage("Por favor, informe o Fabricante.")
               .NotNull().NotEmpty().WithMessage("Por favor, informe o Fabricante.")
            .MaximumLength(100).WithMessage("Muito Extenso! O nome do(s) fabricante(es) pode ter no máximo 100 caracteres.");
            RuleFor(c => c.AnoLancamento)
              .NotEmpty().WithMessage("Por favor, informe o ano de lançamento do produto.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe o ano de lançamento do produto.");
            RuleFor(c => c.QuantidadeEstoque)
              .NotEmpty().WithMessage("Por favor, informe a quantidade em estoque.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe a quantidade em estoque.");
            RuleFor(c => c.Fornecedor)
              .NotEmpty().WithMessage("Por favor, informe o fornecedor.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe o fornecedor.");
            RuleFor(c => c.Categoria)
                .NotEmpty().WithMessage("Por favor, informe a Categoria.")
              .NotNull().NotEmpty().WithMessage("Por favor, informe a Categoria.");
        }
    }
}
