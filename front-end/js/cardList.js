// Em construção, mostrar na reuniação e mandar para o repositorio

if(true){cardGeneration()}

const card = document.querySelectorAll('.card');

for(let iteracao = 0;  iteracao < card.length; iteracao++) {
    card[iteracao].addEventListener('click', event => {
        const classNameOfClickedElement = event.target.classList[0];
        const classeNames = ['label']
        const NoCondition = classeNames.some(classeName => 
        classeName === classNameOfClickedElement)

        if(!NoCondition) {
            alert('Teste');
        } 
    })
}

function cardGeneration(Qtd_pokemon = 10) {
    for(let i = 1; i <= Qtd_pokemon; i++){
        let div = document.createElement('div');
        insertHtmlCard(div);
        scrollbar.appendChild(div);
    }
}

function insertHtmlCard(div) {
    div.className = 'card';
    div.innerHTML += `<img class='imagem_card_list' src='img/000.png'/>`;
    div.innerHTML += `<h2 class='name_pokemon_list'>Nome_pokemon<h2/>`;
    div.innerHTML += `<div class='labelList'>Tipo<div/>`;
    div.innerHTML += `<div class='labelList'>Categoria<div/>`;
}
