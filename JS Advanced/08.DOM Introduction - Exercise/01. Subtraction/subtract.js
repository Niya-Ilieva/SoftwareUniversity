function subtract() {
    const firstNum = Number(document.querySelector('#firstNumber').value);
    const secondNum = Number(document.querySelector('#secondNumber').value);

    const result = firstNum - secondNum;

    document.getElementById('result').innerHTML = result;
}