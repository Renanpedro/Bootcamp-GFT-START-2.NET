using CursoAPI.Controllers;
using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace CursoTest
{
    
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;

        public CategoriasControllerTest()
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Context>();
            _categoria = new Categoria { Id = 1, Descricao = "Teste Categoria" };

            _mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object);
            _mockContext.Setup(m => m.Categorias.FindAsync(1)).ReturnsAsync(_categoria);

            _mockContext.Setup(m => m.SetModified(_categoria));

            _mockContext.Setup(m => m.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1);
        }

        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);
            await service.GetCategoria(1);
            _mockSet.Verify(m => m.FindAsync(1), Times.Once());

        }

        [Fact]
        public async Task Put_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);
            await service.PutCategoria(1, _categoria);
            _mockContext.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>())),Times.Once());
        }

    }


}
