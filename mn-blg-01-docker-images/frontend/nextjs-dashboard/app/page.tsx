import Link from 'next/link';
import { getUsers } from '@/app/lib/data';
import { User } from './lib/definitions';

export default async function Page() {
  var users = await getUsers();
  return (
    <main className="flex min-h-screen flex-col p-6">
   
      <div className="mt-4 flex grow flex-col gap-4 md:flex-row">
        <div className="flex flex-col justify-center gap-6 rounded-lg bg-gray-50 px-6 py-10 md:w-2/5 md:px-20">
          <p className={`text-xl text-gray-800 md:text-3xl md:leading-normal`}>
            <strong>Users in your database.</strong>
          </p>
       
        </div>
        <div className="flex items-center justify-center p-6 md:w-3/5 md:px-28 md:py-12">
        <table className="hidden min-w-full rounded-md text-gray-900 md:table">
          <thead className="rounded-md bg-gray-50 text-left text-sm font-normal">
            <tr>
              <th scope="col" className="px-4 py-5 font-medium sm:pl-6">Name</th>
              <th  scope="col" className="px-4 py-5 font-medium sm:pl-6">Email</th>
            </tr>
          </thead>
          <tbody className="divide-y divide-gray-200 text-gray-900">

            {users.map((user) => (
              <tr key={user.id} className="group" >
                <td className="whitespace-nowrap bg-white px-4 py-5 text-sm">{user.name}</td>
                <td className="whitespace-nowrap bg-white px-4 py-5 text-sm">{user.email}</td>
              </tr>
            ))}
          </tbody>  
        </table>
        </div>
      </div>
    </main>
  );
}

