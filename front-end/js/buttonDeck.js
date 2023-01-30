const button = document.querySelectorAll('.button_deck');
const telaFundo = document.querySelector('.tela_fundo_deck');
const pk_deck1 = document.querySelectorAll('.pk_deck1');
const pk_deck2 = document.querySelectorAll('.pk_deck2');
const pk_deck3 = document.querySelectorAll('.pk_deck3');
const content1 = document.querySelector('#contents_pk_deck1');
const content2 = document.querySelector('#contents_pk_deck2');
const content3 = document.querySelector('#contents_pk_deck3');

button.forEach((button) => {
    button.addEventListener('click', event => {
        telaFundo.style.display = 'block';
        const el = event.target;
        const id = el.id;
        
        if(id === "deck1"){
            content1.style.display = 'grid';
        } 
        
        if (id === "deck2") {
            content2.style.display = 'grid';
        } 
        
        if (id === "deck3") {
            content3.style.display = 'grid';
        }

     })
});

telaFundo.addEventListener('click', event => {
    const classNameOfClickedElement = event.target.classList[0];
    const classeNames = ['fechar_deck', 'tela_fundo_deck']
    const closeCondition = classeNames.some(classeName => 
    classeName === classNameOfClickedElement)

    if(closeCondition){
        telaFundo.style.display = 'none';
        content1.style.display = 'none';
        content2.style.display = 'none';
        content3.style.display = 'none';
    }    
})
