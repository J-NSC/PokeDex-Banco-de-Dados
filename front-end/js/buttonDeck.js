const button = document.querySelectorAll('.button_deck');
const telaFundo = document.querySelector('.tela_fundo_deck');
const pk_deck1 = document.querySelectorAll('.pk_deck1');
const pk_deck2 = document.querySelectorAll('.pk_deck2');
const pk_deck3 = document.querySelectorAll('.pk_deck3');
const imgDeck = document.querySelectorAll('.img_deck')
const content1 = document.querySelector('#contents_pk_deck1');
const content2 = document.querySelector('#contents_pk_deck2');
const content3 = document.querySelector('#contents_pk_deck3');
const btnRemoveTrocarDeck1 = document.querySelector('.bkg_removePokemon1');
const btnRemoveTrocarDeck2 = document.querySelector('.bkg_removePokemon2');
const btnRemoveTrocarDeck3 = document.querySelector('.bkg_removePokemon3');

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
        btnRemoveTrocarDeck1.style.display1 = 'none'
        btnRemoveTrocarDeck2.style.display2 = 'none'
        btnRemoveTrocarDeck3.style.display3 = 'none'
    }    
})

// clicando na imagem
pk_deck1.forEach((pk_deck1) => {
    pk_deck1.addEventListener('click', event => {
        const classNameOfClickedElement = event.target.classList[0];
        const classeNames = ['pk_deck1']
        const verification = classeName => classeName === classNameOfClickedElement
        const condition = classeNames.some(verification)

        if(!condition) {
            btnRemoveTrocarDeck1.style.display = 'grid';
        }
    }) 
})

pk_deck2.forEach((pk_deck2) => {
    pk_deck2.addEventListener('click', event => {
        const classNameOfClickedElement = event.target.classList[0];
        const classeNames = ['pk_deck2']
        const verification = classeName => classeName === classNameOfClickedElement
        const condition = classeNames.some(verification)

        if(!condition) {
            btnRemoveTrocarDeck2.style.display = 'grid';
        }
    }) 
})

pk_deck3.forEach((pk_deck3) => {
    pk_deck3.addEventListener('click', event => {
        const classNameOfClickedElement = event.target.classList[0];
        const classeNames = ['pk_deck2']
        const verification = classeName => classeName === classNameOfClickedElement
        const condition = classeNames.some(verification)

        if(!condition) {
            btnRemoveTrocarDeck3.style.display = 'grid';
        }
    }) 
})

// remção pokemon
const removeImgDeck1 = document.querySelector('.remover1');
const removeImgDeck2 = document.querySelector('.remover2');
const removeImgDeck3 = document.querySelector('.remover3');

removeImgDeck1.addEventListener('click', () => {
    removerPkDeck1();
})

removeImgDeck2.addEventListener('click', () => {
    removerPkDeck2();
})

removeImgDeck3.addEventListener('click', () => {
    removerPkDeck3();
})

function removerPkDeck1() {
    //btnRemoveTrocarDeck1.style.display = 'none'
    
    if(addDeck1[0].innerHTML != '') {
        addDeck1[0].innerHTML = '';
    } else if(addDeck1[1].innerHTML != '') {
        addDeck1[1].innerHTML = '';
    } else if(addDeck1[2].innerHTML != '') {
        addDeck1[2].innerHTML = '';
    } else if(addDeck1[3].innerHTML != '') {
        addDeck1[3].innerHTML = '';
    } else if(addDeck1[4].innerHTML != '') {
        addDeck1[4].innerHTML = '';
    } else if(addDeck1[5].innerHTML != '') {
        alert('Pokmon não pode ser removido')
    }
}

function removerPkDeck2() {
    //btnRemoveTrocarDeck2.style.display = 'none'
    
    if(addDeck2[0].innerHTML != '') {
        addDeck2[0].innerHTML = '';
    } else if(addDeck2[1].innerHTML != '') {
        addDeck2[1].innerHTML = '';
    } else if(addDeck2[2].innerHTML != '') {
        addDeck2[2].innerHTML = '';
    } else if(addDeck2[3].innerHTML != '') {
        addDeck2[3].innerHTML = '';
    } else if(addDeck2[4].innerHTML != '') {
        addDeck2[4].innerHTML = '';
    } else if(addDeck2[5].innerHTML != '') {
        alert('Pokmon não pode ser removido')
    }
}

function removerPkDeck3() {
    //btnRemoveTrocarDeck3.style.display = 'none'
    
    if(addDeck3[0].innerHTML != '') {
        addDeck3[0].innerHTML = '';
    } else if(addDeck3[1].innerHTML != '') {
        addDeck3[1].innerHTML = '';
    } else if(addDeck3[2].innerHTML != '') {
        addDeck3[2].innerHTML = '';
    } else if(addDeck3[3].innerHTML != '') {
        addDeck3[3].innerHTML = '';
    } else if(addDeck3[4].innerHTML != '') {
        addDeck3[4].innerHTML = '';
    } else if(addDeck3[5].innerHTML != '') {
        alert('Pokmon não pode ser removido')
    }
}
