import {User} from './definitions';

export async function getUsers() {
  try {

    const SERVICE_URL = process.env.NEXT_PUBLIC_SERVICE_URL;
    console.warn('SERVICE_URL:', SERVICE_URL);
    const users= (await fetch(`${SERVICE_URL}/api/user`));
    console.log(users);
    return (await users.json()) as User[];
  } catch (error) {
    console.error('Failed to fetch user:', error);
    //throw new Error('Failed to fetch user.');
    return [];
  }
}
