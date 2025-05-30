
document.getElementById('studentForm').addEventListener('submit', function(e) {
    e.preventDefault();
    const name = document.getElementById('name').value;
    const age = document.getElementById('age').value;
    const grade = document.getElementById('grade').value;
    const record = document.createElement('div');
    record.textContent = `${name}, Age: ${age}, Grade: ${grade}`;
    document.getElementById('records').appendChild(record);
});
