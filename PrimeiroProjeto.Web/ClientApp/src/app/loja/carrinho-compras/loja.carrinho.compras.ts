import { Produto } from "../../modelo/produto";


export class LojaCarrinhoCompras {

  public produtos: Produto[] = [];

  public adicionar(produto: Produto) {
    var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");
    if (!produtoLocalStorage) {
      this.produtos.push(produto);
    } else {
      this.produtos = JSON.parse(produtoLocalStorage);
      this.produtos.push(produto);

    }
    localStorage.setItem("produtoLocalStorage", JSON.stringify(this.produtos));

  }

  public obterProdutos(): Produto[] {
    var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");
    if (produtoLocalStorage) {
      return JSON.parse(produtoLocalStorage);
    }
  }

  public removerProduto(produto: Produto) {
    var produtoLocalStorage = localStorage.getItem("produtoLocalStorage");
    if (produtoLocalStorage) {
      this.produtos = JSON.parse(produtoLocalStorage);
      this.produtos = this.produtos.filter(p => p.id != produto.id);
      localStorage.setItem("produtoLocalStorage", JSON.stringify(this.produtos));
    }
  }

  public atualizar(produto: Produto[]) {
    localStorage.setItem("produtoLocalStorage", JSON.stringify(this.produtos));
  }

  limparCarrinhoCompras() {
    localStorage.setItem("produtoLocalStorage", "");
  }


}
