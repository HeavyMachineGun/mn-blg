import {User} from './definitions';

export async function getUsers() {
  try {
    
    const users= (await fetch('http://backend:8080/user'));
    console.log(users);
    return (await users.json()) as User[];
  } catch (error) {
    console.error('Failed to fetch user:', error);
    //throw new Error('Failed to fetch user.');
    return [];
  }
}
