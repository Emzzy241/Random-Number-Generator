// Writing a random number generator in Javascript and later I will now convert it to one in C#

// function getRandomNumber()

const getRandomNumber = (min, max)=>{
    // I passed in 2 arguments which is the min and the max number my user wants to generate this random number from
    // Ensure the arguments are numbers
    min = Number(min);
    max = Number(max);

    // Swapping the numbers if the min is greater than the max
    if(min > max)
    {
        [min, max] = [max, min];
    }
    // Now its time to generate the random number between min and max(inclusive)
    return Math.floor(Math.random() * (max - min + 1)) + min;
}