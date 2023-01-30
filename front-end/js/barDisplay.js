const buttonBar = document.querySelectorAll('.button_bar');
const contentsBarData = document.querySelector('.contentsBarData');

buttonBar.forEach((buttonBar) => {
    buttonBar.addEventListener("click", event => {
        const el = event.target;
        const id = el.id;

        if(id === 'descrição') description();
        if(id === 'estatisticas') estatisticas();
        if(id === 'ataques') ataques();
        if(id === 'fraquezas') fraquezas();
       
    });
});

function description(){
    open();
    contentsBarData.innerHTML = `<p id='desText'>
        Bulbasaur é uma criatura quadrúpede réptil que lembra um dinossauro jovem, 
        com um azul-verde manchado. Ele tem três dedos brancos ou garras crescendo 
        fora de suas quatro pernas, e seus olhos são de um vermelho brilhante.
    </p>`
}

function estatisticas(){
    open();
    contentsBarData.innerHTML = `<p id='desText'>Estatisicas</p>`;
}

function ataques(){
    open();
    contentsBarData.innerHTML = `<p id='desText'>Ataques:</p>`;
}

function fraquezas(){
    open();
    contentsBarData.innerHTML = `<p id='desText'>Fraquezas</p>`;
}

function open(){
    contentsBarData.style.display = 'flex';
}