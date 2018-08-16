const { Prisma } = require('prisma-binding')

const { GraphQLServer } = require('graphql-yoga')

const resolvers = {
  Query: {
    horses: (root, args, context, info) => {
      return context.db.query.horses(
	  {
		data: {
			where: args.where, 
			orderBy: args.orderBy,
			skip: args.skip,
			after: args.after,
			before: args.before,
			first: args.first,
			last: args.last
		  }
	  }, info)
    },
    horsedb: (root, args, context, info) => {
      return context.db.query.horse(
	  {
		data: {
			where: args.where
		  }
	  }, info)
    },	
	horse: (root, args, context, info) => {
      return context.db.query.horse({where: {id: args.id}}, info)
    },
	
	owners: (root, args, context, info) => {
      return context.db.query.owners(
	  {
		data: {
			where: args.where, 
			orderBy: args.orderBy,
			skip: args.skip,
			after: args.after,
			before: args.before,
			first: args.first,
			last: args.last
		  }
	  }, info)
    },
	
	owner: (root, args, context, info) => {
      return context.db.query.owner({where: {id: args.id}}, info)
    },
	
    info: () => `This is the API of a Hackernews Clone`,
    feed: (root, args, context, info) => {
      return context.db.query.links(
	  {
	  }, info)
    },
  },
  Mutation: {
    createHorse: (root, args, context, info) => {
      return context.db.mutation.createHorse({
        data: {
          name: args.name,
          color: args.color,
		  gender: args.gender,
		  birthyear: args.birthyear,
        },
      }, info)
    },
	
	createOwner: (root, args, context, info) => {
      return context.db.mutation.createOwner({
        data: {
			firstname: args.firstname,
			lastname: args.lastname,
			horses: {connect: {id: args.horseid}},
			},
		},info)
	},
	
    post: (root, args, context, info) => {
      return context.db.mutation.createLink({
        data: {
          url: args.url,
          description: args.description,
        },
      }, info)
    },
  },
}

// 3
const server = new GraphQLServer({
  typeDefs: './src/schema.graphql',
  resolvers,
  context: req => ({
    ...req,
    db: new Prisma({
      typeDefs: 'src/generated/prisma.graphql',
      endpoint: 'https://eu1.prisma.sh/per-lidebrandt/graphqldemo1/dev',
      secret: 'mysecret123',
      debug: true,
    }),
  }),
})

server.start(() => console.log(`Server is running on http://localhost:4000`))