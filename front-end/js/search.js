const contentScrollbar = document.querySelector("#scrollbar")
const inputSearch = document.querySelector("input[type='search']");
const tipo = document.querySelector('.labelListType');

// ainda em construção: filtragem de pokemon por
cardGeneration()

function cardGeneration(Qtd_pokemon = 30) {
    for(let id = 1; id <= Qtd_pokemon; id++){
        let div = document.createElement('div');
        contentsCard(div, id)
        scrollbar.appendChild(div);
    }
}

function contentsCard(div, id) {
    div.className = 'card';
    div.id = `${id}`;
    div.innerHTML += `<img class='imagem_card_list' id='${div.id}' src='img/pk/${div.id}.png'/>`;
    div.innerHTML += `<h2 class='name_pokemon_list' id='${div.id}'>Nome_pokemon<h2/>`;
    div.innerHTML += `<div class='labelListType'>Tipo<div/>`;
    div.innerHTML += `<div class='labelListCategoria'>Categoria<div/>`;
}