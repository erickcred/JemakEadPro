
/* Caso os cards tenho a apresentação da Categoria */
//setInterval(() => {
    document.querySelectorAll(".products h4.description").forEach(item => {
        if (item.textContent == "Contábil") {
            item.classList.add("color-contabil");
        }
        if (item.textContent == "Trabalhista/Previdenciária") {
            item.classList.add("color-trabalhista");
        }
        if (item.textContent == "Tributário") {
            item.classList.add("color-tributario");
        }
        if (item.textContent == "Fiscal") {
            item.classList.add("color-fiscal");
        }
        if (item.textContent == "LGPD") {
            item.classList.add("color-lgpd");
        }
        if (item.textContent == "Previdenciária") {
            item.classList.add("color-previdenciaria");
        }
    });
//}, 1000)


/* Processo para visulização de cards dos cursos */
let buttonMaisCursos = document.querySelector(".carregarCursos");
let cards = document.querySelectorAll("#courses .products > .item");
let totalCards;


function ocultaCards() {
    cards.forEach((item, index) => {
        item.classList.add("oculta");
        totalCards = 6;
        if (index < totalCards) {
            console.log(item)
            item.classList.remove("oculta");
        }
    });
}
ocultaCards();

function mostraCards() {
    totalCards += 6;
    cards.forEach((item, index) => {
        item.classList.add("oculta");
        if (index < totalCards ) {
            item.classList.remove("oculta");
            console.log(totalCards)
        }
    });
}

buttonMaisCursos.addEventListener("click", () => {
    mostraCards();
});


// Evento para Assinaturas item de categorias cola preferência no top
document.addEventListener("scroll", function() {
    console.log(window.pageYOffset)
    let height = window.pageYOffset;
    if (height > 507.20) {
        console.log("Igual")
        document.querySelector(".categories").classList.add("fixa-search");
    } else {
        document.querySelector(".categories").classList.remove("fixa-search");
    }
  });


/* Muda none do input de pesquisa mobile*/
//document.querySelector("#search-mobile").placeholder = "Pesquisar";