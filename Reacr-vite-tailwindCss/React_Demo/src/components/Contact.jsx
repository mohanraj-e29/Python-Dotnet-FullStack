import React from 'react'

function Contact() {
  return (
    <div className='flex flex-col mb-10 mx-auto'>
      <div className='flex justify-center items-center'>
        <form 
        action='' method='POST' className='flex flex-col w-full md:w-7/12'>
        <input type='text' name='name' placeholder='Name' 
        className='p-2 bg-transparent border-2 rounded-md focus:outline-none'/>

        <input type='text' name='email' placeholder='E-mail' 
        className='my-2 p-2 bg-transparent border-2 rounded-md focus:outline-none'/>

        <textarea name='message ' placeholder='message' rows='10'
        className='p-2 mb-4 border-2 rounded-md focus:outline-none'>
        </textarea>

        <button type='button' className='text-center inline-block px-8 py-3 w-max text-base font-medium
        rounded-md  text-white bg-gradient-to-r from-yellow-500 to-pink-500 drop-shadow-md hover:stroke-white'>
          Work with me...
        </button>
        </form>

      </div>
      
    </div>
  )
}

export default Contact;
