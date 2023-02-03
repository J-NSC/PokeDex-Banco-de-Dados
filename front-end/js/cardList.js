const barTela = document.querySelector('.barDataDisplay');
const buttonDisplay = document.querySelector('.button_display');
const buttonFilter = document.querySelector('.button_filter')
const card = document.querySelectorAll('.card');


card.forEach((card) => {
    card.addEventListener('click', event => {
        const classNameOfClickedElement = event.target.classList[0];
        const classeNames = ['labelListType', 'labelListCategoria']
        const verification = classeName => classeName === classNameOfClickedElement
        const NoCondition = classeNames.some(verification)
        const el = event.target;
        const id_Pk = el.id; 

        if(!NoCondition) {
            openBar(tela(id_Pk))
        } 
    })
})

function openBar() {
    barTela.style.display = 'flex';
}

const contentsTela = document.querySelector('#display');
const numberPk = document.querySelector('#divNumber');
const namePk = document.querySelector('#divNamePk');
const imgCard = document.querySelector('#card');

function tela(id_Pk) {
    contentsTela.style.background = '#5DD39E';
    numberPk.innerHTML = `<p id=number># ${id_Pk}</p>`;
    namePk.innerHTML = `<p id=namePk>Nome_Pokemon</p>`;
    imgCard.innerHTML = `<img id=imgCard src='img/pk/${id_Pk}.png'/>`;
    buttonDisplay.style.background = '#5DD39E';
    buttonDisplay.style.display = 'flex';
}

