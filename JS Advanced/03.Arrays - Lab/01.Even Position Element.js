function evenPosition([...input]) {
    let result = [];
    for (let i = 0; i < input.length; i+=2) {
       result.push(input[i]);
    }
    console.log(result.join(' '));
}
evenPosition(['20', '30', '40', '50', '60']);
evenPosition(['5', '10']);