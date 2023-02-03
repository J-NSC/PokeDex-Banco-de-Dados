const btn = document.querySelector('.tela_button_display');
const btnOpen = document.querySelector('.button_display');
const btnAdd = document.querySelectorAll('.btn_add_deck')
const addDeck1 = document.querySelectorAll('.pk_deck1');
const addDeck2 = document.querySelectorAll('.pk_deck2');
const addDeck3 = document.querySelectorAll('.pk_deck3');
const numeroPk = document.querySelectorAll(".card");

btnOpen.addEventListener('click', () => {
    btn.style.display = 'block';
})

btnAdd.forEach((btnAdd) => {
    btnAdd.addEventListener('click', event => {
        const classNameOfClickedElement = event.target.classList[0];
        const classeNames = ['btn_add_deck']
        const closeCondition = classeNames.some(classeName => 
        classeName === classNameOfClickedElement)
        const el = event.target;
        const id = el.id;

        if(closeCondition){
            if(id === "add1") {
                addInsideDeck1(num.pop(0));
            }
    
            if(id === "add2") {
                addInsideDeck2(num.pop(0));
            }
    
            if(id === "add3") {
                addInsideDeck3(num.pop(0));
            }   
        }        
    })
});

//criação do remover e trocar ataque
const removeImgDeck = document.querySelector('.remover');
const trocaAtaque = document.querySelector('.trocarAtaque');

removeImgDeck.addEventListener('click', () => {

})

trocaAtaque.addEventListener('click', () => {
    
})

function remover() {
    btnRemoveTrocarDeck.style.display = 'none'
    alert('Remove Pokemon')
}

function trocarAtaque() {
    btnRemoveTrocarDeck.style.display = 'none'
    alert('Trocar Ataque')
}


let num = [];

card.forEach((card) => {
    card.addEventListener('click', event => {
            const el = event.target;
            const id_Pk = el.id;
            num.push(id_Pk);
    })
})


function addInsideDeck1(id) {
    btn.style.display = 'none';
    
    if(addDeck1[0].innerHTML === '') {
        addDeck1[0].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if(addDeck1[1].innerHTML === '') {
        addDeck1[1].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if(addDeck1[2].innerHTML === '') {
        addDeck1[2].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if (addDeck1[3].innerHTML === '') {
        addDeck1[3].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if (addDeck1[4].innerHTML === '') {
        addDeck1[4].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if (addDeck1[5].innerHTML === '') {
        addDeck1[5].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    }
}

function addInsideDeck2(id) {
    btn.style.display = 'none';
    if(addDeck2[0].innerHTML === '') {
        addDeck2[0].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if(addDeck2[1].innerHTML != addDeck2[0].innerHTML) {
        addDeck2[1].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if(addDeck2[2].innerHTML === '') {
        addDeck2[2].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if (addDeck2[3].innerHTML === '') {
        addDeck2[3].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if (addDeck1[4].innerHTML === '') {
        addDeck2[4].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if (addDeck2[5].innerHTML === '') {
        addDeck2[5].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    }
}

function addInsideDeck3(id) {
    btn.style.display = 'none';
    if(addDeck3[0].innerHTML === '') {
        addDeck3[0].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if(addDeck3[1].innerHTML === '') {
        addDeck3[1].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if(addDeck3[2].innerHTML === '') {
        addDeck3[2].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if (addDeck3[3].innerHTML === '') {
        addDeck3[3].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if (addDeck3[4].innerHTML === '') {
        addDeck3[4].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    } else if (addDeck3[5].innerHTML === '') {
        addDeck3[5].innerHTML = `<img class='img_deck' id=${id} src='img/pk/${id}.png'/>`;
    }
}
