const button = document.querySelectorAll('.button_deck')
const telaFundo = document.querySelector('.tela_fundo_deck')


for(let i = 0; i < button.length; i++) {
    button[i].addEventListener('click', () => {
        telaFundo.style.display = 'block';
     })
}

telaFundo.addEventListener('click', event => {
    const classNameOfClickedElement = event.target.classList[0];
    const classeNames = ['fechar_deck', 'tela_fundo_deck']
    const closeCondition = classeNames.some(classeName => 
    classeName === classNameOfClickedElement)
   
    if(closeCondition) {
        telaFundo.style.display = 'none';
    } 
      
})


 