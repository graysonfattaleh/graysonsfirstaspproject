

$("#grade_calculator_btn").click(
    function () {

        let a = $('#assignments').val() * 0.5
        calc_grade = (
            a +
            $('#group_projects').val() * 0.1 +
            $('#quizzes').val() * 0.1 +
            $('#exams').val() * 0.2 +
            $('#intex').val() * 0.1)

        let letter_grade = ''
        if (calc_grade >= 94) {
            letter_grade = 'A'

        }
        else if(calc_grade >= 90){
            letter_grade = 'A-'

        }
        else if(calc_grade >= 87){
            letter_grade = 'B+'

        }
        else if(calc_grade >= 84){
            letter_grade = 'B'

        }
        else if(calc_grade >= 80){
            letter_grade = 'B-'

        }
        else if(calc_grade >= 77){
            letter_grade = 'C+'

        }
        else if(calc_grade >= 74){
            letter_grade = 'C'

        }
        else if(calc_grade >= 70){
            letter_grade = 'C-'
        }
        else if(calc_grade >= 67){
            letter_grade = 'D+'

        }
        else if(calc_grade >= 64){
            letter_grade = 'D'

        }
        else if(calc_grade >= 60){
            letter_grade = 'D-'

        }
        else{
            letter_grade = 'E'

        }

        $('#calculated_grade').html(calc_grade.toFixed(2) + '%: ' + letter_grade)
    })

/*let calculate_button = document.getElementById('grade_calculator_btn');
// get other inputs
let assignment_score = document.getElementById('assignments');
let group_projects_score = document.getElementById('group_projects');
let quizzes_score = document.getElementById('quizzes');
let exams_score = document.getElementById('exams');
let intex_score = document.getElementById('intex');
let final_grade = document.getElementById('calculated_grade');


// what to do when button clicked//
calculate_button.addEventListener("click", function () {
    let calc_grade = (assignment_score.value * 0.5 +
        group_projects_score.value * 0.1 + quizzes_score.value * 0.1 +
        exams_score.value * 0.2 + intex_score.value * 0.1)
    final_grade.innerHTML = (calc_grade + '%')
});*/